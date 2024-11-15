# InterfacesInteligentes05
# Coin & Zombie Controller for Unity

This repository contains two Unity scripts, **`CoinController`** and **`ZombieController`**, designed to demonstrate interactive gameplay mechanics involving teleportation, scoring, and object behavior in response to player interactions.

---

## Features

### `CoinController.cs`
This script manages coins in the game environment:
- **Teleportation**: Coins teleport to random positions within a defined range when gazed upon.
- **Scoring System**: Players earn points each time they gaze at a coin.
- **Dynamic UI Updates**: The score is displayed and updated in real-time on the game screen.

### `ZombieController.cs`
This script handles zombie movement and interaction:
- **Targeted Movement**: Zombies move toward the player's camera at a specified speed.
- **Material Changes**: Zombies change material when gazed at.
- **Spawn Management**: Zombies can spawn at predefined points when gazed at.

---

## Example Usage

- **CoinController**: Place multiple coins in your scene and define their teleportation ranges. Gaze at the coins to collect points.
- **ZombieController**: Add zombies that move toward the player. Use predefined spawn points to dynamically change their positions.

---

## License

These scripts are licensed under the [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0). Refer to the license file for more details.

---

## Contributing

Contributions are welcome! Please submit a pull request or raise an issue if you have suggestions or improvements.
