# Tic-Tac-Toe Console Game in C#

A simple **console-based Tic-Tac-Toe game** built with C#. Two players can play against each other in the terminal.

---

## Features

- Two-player gameplay (X vs O)  
- Interactive console input for row and column  
- Detects invalid moves and prompts for a valid one  
- Detects a winner or a tie  
- Simple, beginner-friendly C# implementation  

---

## How to Play

1. Clone or download this repository.  
2. Open the project in **Visual Studio** or any C# IDE.  
3. Build and run the project.  
4. Players take turns entering the **row** and **column** numbers (1-3) to place their mark.  
5. The game ends when:
   - A player wins by aligning three marks horizontally, vertically, or diagonally.  
   - All cells are filled and the game is a tie.  

**Example Input:**

```
Player X, enter row and column (e.g., 1 3):
```

---

## Code Structure

- `Program.cs` – Contains all the game logic including:
  - Board initialization  
  - Player input handling  
  - Win/tie checking  
  - Switching turns  

---

## How to Run

```bash
dotnet run
```

or run the project directly in Visual Studio using **F5**.

---

## Future Improvements

- Add single-player mode with a basic AI  
- Add a replay option after game ends  
- Add colors for X and O in the console  
