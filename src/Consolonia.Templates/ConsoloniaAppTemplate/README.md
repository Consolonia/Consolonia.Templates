# ConsoloniaAppTemplate

A terminal user interface application built with [Consolonia](https://github.com/consolonia/consolonia),
an [Avalonia](https://avaloniaui.net) render backend that draws to the console.

## Running

```
dotnet run
```

Consolonia needs a real terminal, so prefer running from a terminal window rather
than from an IDE's embedded output pane.

## Layout

| Path                                | Purpose                                              |
|-------------------------------------|------------------------------------------------------|
| `Program.cs`                        | Entry point; configures the Avalonia/Consolonia host |
| `App.axaml`                         | Application-level styles and theme                   |
| `MainWindow.axaml`                  | The main window's UI                                 |
| `ViewModels/MainWindowViewModel.cs` | View model, using CommunityToolkit.Mvvm              |

## Learn more

* [Consolonia documentation](https://github.com/consolonia/consolonia)
* [Avalonia documentation](https://docs.avaloniaui.net)
