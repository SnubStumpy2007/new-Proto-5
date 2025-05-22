# Click Target Game (A Unity Junior Developer Certificaton Tutorial project)

A simple Unity clicker game where players click on various targets to score points while avoiding bombs. The game features three difficulty levels that affect the spawn rate of targets.

---

## Game Overview

- **Goal:** Click on good targets to earn points.
- **Targets:**  
  - **Good objects:**  
    - Radioactive ball  
    - Eyeball  
    - Soccer ball  
  - **Bad object:**  
    - Bomb (ends the game immediately if clicked)
- **Game Over Conditions:**  
  - Clicking a bomb  
  - Letting a good object fall past the player without clicking it

---

## Controls

- Click on the moving targets to score points.
- Avoid clicking on bombs to keep playing.
- Select difficulty from the title screen to start the game.

---

## Difficulty Levels

- Easy  
- Medium  
- Hard

Difficulty affects how fast targets spawn:
- Higher difficulty → faster spawn rate.

---

## Scripts

### Difficulty.cs

Handles difficulty selection via UI buttons. When a difficulty button is clicked, it calls the GameManager to start the game with the chosen difficulty.

**Key points:**

- Listens for button clicks.
- Sends difficulty value to GameManager.
- Logs clicks for debugging.

---

### GameManager.cs

Main game controller managing game state, score, spawning targets, and UI.

**Key points:**

- Tracks score and game status (`isGameActive`).
- Starts and restarts the game.
- Controls spawning of targets with spawn rate influenced by difficulty.
- Shows/hides UI elements like the title screen, game over text, and restart button.

---

### Targets.cs

Controls individual target behavior including movement, clicking, scoring, and game over conditions.

**Key points:**

- Applies random force and torque to targets on spawn.
- Detects mouse clicks on targets.
- Instantiates explosion particle effects on click.
- Triggers game over if a bomb is clicked or if a good target falls past the trigger without being clicked.
- Updates the score via GameManager for good targets.

---

## How to Use

1. Open the Unity project.
2. Make sure the `GameManager` object exists in the scene and is configured with references to UI elements and target prefabs.
3. Set up the UI with buttons linked to the `Difficulty` script.
4. Play the game in the editor or build to test.

---

## Notes

- Targets must be set up as prefabs with proper tags ("Bad" for bombs, others for good targets).
- Ensure the `GameManager` is named exactly as expected so the scripts find it at runtime.
- Adjust spawn rate and target speeds in scripts for balancing gameplay.

---

## License

This project is provided as-is for educational and personal use.

---

Enjoy clicking and scoring!

