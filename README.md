# Serpientes y Escaleras — Snakes & Ladders

Juego de consola implementado en **.NET 10** con **C#**, aplicando **Arquitectura Limpia**, **SOLID** y **TDD** con **xUnit**.

## Estructura del proyecto

```
├── src/
│   ├── GameCore/       # Lógica del juego (desacoplada de la UI)
│   └── GameConsole/    # Aplicación de consola (UI)
└── tests/
    └── GameTests/      # Pruebas unitarias xUnit
```

## Requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

## Ejecutar el juego

```bash
dotnet run --project src/GameConsole
```

Presiona **Enter** en cada turno para tirar el dado. El juego termina al llegar a la casilla 100.

## Ejecutar las pruebas

```bash
dotnet test
```

## Cobertura de pruebas

| Historia | Descripción | UATs |
|----------|-------------|------|
| US1 | El token se mueve por el tablero | 3/3 |
| US2 | El jugador puede ganar la partida | 2/2 |
| US3 | Los movimientos son determinados por el dado | 2/2 |
| **Total** | | **7/7** |

## Principios aplicados

- **SRP**: Cada clase tiene una única responsabilidad (Player, Board, Dice, Game)
- **OCP**: Abierto a extensión (nuevos tipos de dado, nuevos estados de juego)
- **DIP**: Game depende de la abstracción `IDice`, no de `RandomDice`
- **TDD**: Cada UAT se escribió como test antes de implementar (RED → GREEN)
