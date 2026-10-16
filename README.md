# Tournament Tracker

A Windows Forms application for running single-elimination tournaments: register players, group
them into teams, define prize payouts, and (eventually) generate and score matchup rounds.

The app can store its data two ways — a **SQL Server database** or **plain CSV files** — behind a
single `IDataConnection` interface, so the UI never knows which one is in use.

> Status: work in progress. Player, team, and prize creation work end to end. Tournament creation,
> the dashboard, and matchup scoring are still stubs. See [Known gaps](#known-gaps).

## Requirements

- .NET 10 SDK (projects target `net10.0` / `net10.0-windows`)
- Windows — the UI uses Windows Forms
- Visual Studio 2022+ with the *.NET desktop development* workload (recommended)
- For SQL mode only: SQL Server (Express/LocalDB is fine) plus the *Data storage and processing*
  workload for the SQL Database Project

## Solution layout

| Project | Type | What it holds |
| --- | --- | --- |
| [TrackerLibrary/](TrackerLibrary/) | class library (`net10.0`) | Models, the `IDataConnection` abstraction, the SQL and text-file connectors, and `GlobalConfig` |
| [TournamentVw/](TournamentVw/) | class library (`net10.0-windows`) | All the WinForms screens |
| [TrackerUI/](TrackerUI/) | WinExe (`net10.0-windows`) | The executable — `Main` lives here and picks the storage backend |
| [TournamentsDB/](TournamentsDB/) | SQL Database Project | Table and stored-procedure definitions for `TournamentsDB` |

`TrackerUI` is the startup project; it references `TournamentVw`, which references `TrackerLibrary`.

Note: the forms live in the `TournamentVw` *project* but most are declared in the `TrackerUI`
*namespace*, which is why `Program.cs` can construct them without an extra `using`.

## Getting started

```powershell
git clone <this-repo>
cd TournamentTracker
dotnet build TrackerUI/TrackerUI.csproj
dotnet run  --project TrackerUI/TrackerUI.csproj
```

(Build `TrackerUI` rather than the whole solution from the CLI — `dotnet` cannot build the
`.sqlproj` database project. Open `TournamentTracker.sln` in Visual Studio for that.)

Which backend the app uses is chosen in [TrackerUI/Program.cs:15](TrackerUI/Program.cs#L15):

```csharp
GlobalConfig.InitializeConnections(DatabaseType.TextFile);  // or DatabaseType.Sql
```

### Text-file mode (no database needed)

CSV files are written to the directory named by the `filePath` app setting in
[TrackerUI/App.config](TrackerUI/App.config), which defaults to `c:\data\TournamentTracker`:

```powershell
mkdir c:\data\TournamentTracker
```

The directory must exist — the connector creates the files but not the folder. Three files appear
as you use the app:

- `PlayerModels.csv` — `Id, FirstName, LastName, EmailAddress, CellphoneNumber`
- `TeamModels.csv` — `Id, TeamName, PlayerId|PlayerId|...`
- `PrizeModels.csv` — `Id, PlaceNumber, PlaceName, PrizeAmount, PrizePercentage`

Fields are split on `,` with no quoting, so **a comma in any value will corrupt the row**.

### SQL Server mode

1. Open `TournamentTracker.sln` in Visual Studio.
2. Point the `TournamentsDB` project's publish profile at your server — the default
   [TournamentsDB.publish.xml](TournamentsDB/TournamentsDB.publish.xml) targets `localhost` with
   integrated security and creates a database named `TournamentsDB`.
3. Right-click **TournamentsDB → Publish** to create the schema and stored procedures.
4. Check the `Tournaments` connection string in [TrackerUI/App.config](TrackerUI/App.config)
   matches your server.
5. Change `Program.cs` to pass `DatabaseType.Sql`.

`GlobalConfig.ConnectionString("Tournaments")` throws a `ConfigurationErrorsException` with a clear
message if that entry is missing, which is the usual first symptom of a mis-copied config.

## How the data layer fits together

Everything the UI needs goes through one interface,
[IDataConnection](TrackerLibrary/DataAccess/IDataConnection.cs):

```csharp
PrizeModel        CreatePrize(PrizeModel model);
PlayerModel       CreatePlayer(PlayerModel model);
TeamModel         CreateTeam(TeamModel model);
List<PlayerModel> GetPlayers_All();
```

`GlobalConfig.InitializeConnections` picks the implementation once at startup and exposes it as the
static `GlobalConfig.Connection`. Forms call it directly, e.g. in
[TeamCreateForm.cs](TournamentVw/TeamCreateForm.cs).

- [SQLConnector](TrackerLibrary/DataAccess/SQLConnector.cs) uses **Dapper** and calls stored
  procedures only (`spPlayer_Insert`, `spTeams_Insert`, `spTeamMembers_Insert`, `spPrizes_Insert`,
  `spPlayer_GetAll`); the database assigns IDs via `SCOPE_IDENTITY()`.
- [TextConnector](TrackerLibrary/DataAccess/TextConnector.cs) reads the whole file, computes the
  next ID as `max(Id) + 1`, appends, and rewrites the file. Serialization lives in the extension
  methods in [TextConnectorProcessor.cs](TrackerLibrary/DataAccess/TextConnectorProcessor.cs).

**Adding a new operation** means adding it to `IDataConnection` and implementing it in *both*
connectors — plus a stored procedure in `TournamentsDB/dbo/StoredProcedures/` for the SQL side.

### Database schema

`Players`, `Teams`, and `TeamMembers` (the team↔player join table) are in use today. `Prizes`,
`Tournaments`, `TournamentEntries`, `TournamentPrizes`, `Matchups`, and `MatchupEntries` are
defined in [TournamentsDB/dbo/Tables/](TournamentsDB/dbo/Tables/) but not yet wired up.

## Known gaps

Worth knowing before you go looking for a bug that is really just unfinished work:

- `TournamentCreateForm`, `TournamentDashboardForm`, and `TournamentView` are empty shells.
- `Program.cs` opens `TeamCreateForm` directly instead of the dashboard, for quick iteration.
- `TournamentModel`, `MatchupModel`, and `MatchUpEntryModel` have no persistence in either connector.
- The `Players` table column is spelled `EmailAdress` (missing "d"); `spPlayer_Insert` maps around it.
- `Matchups.WinnerTeamId` and `MatchupRound` are typed `NCHAR(10)` rather than `INT`.
- Text-file mode has no escaping and no concurrency protection — one user, one process.
- `TrackerUI` also contains an unused duplicate `TournamentView` alongside `TournamentVw`'s copy.

## Credits

Built as a learning project following Tim Corey's Tournament Tracker series.
