# 🏃 Endless Runner

> **Jump over obstacles, survive as long as you can. Simple, clean, and endlessly replayable.**

![Platform](https://img.shields.io/badge/Platform-Android-3DDC84?style=flat&logo=android&logoColor=white)
![Engine](https://img.shields.io/badge/Engine-Unity-000000?style=flat&logo=unity&logoColor=white)
![Language](https://img.shields.io/badge/Language-C%23-239120?style=flat&logo=csharp&logoColor=white)
![Status](https://img.shields.io/badge/Status-Shipped-brightgreen?style=flat)
![Note](https://img.shields.io/badge/Note-First%20Game-orange?style=flat)

---

## 🎮 Play It

[![Play on itch.io](https://img.shields.io/badge/Play_on-itch.io-FA5C5C?style=flat&logo=itch.io&logoColor=white)](https://gameofbugsofficial.itch.io)

---

## 📖 About

Endless Runner is my first shipped Unity game — a casual 2D endless runner where you jump over obstacles to survive as long as possible.

No fluff, no complexity. Just a clean game loop that works. Building this taught me the fundamentals of Unity game development: player physics, spawning systems, collision detection, and game state management — the foundation everything else I've built since rests on.

---

## 🕹️ How to Play

- Tap / click to jump
- Clear obstacles to keep running
- Hit one — game over
- Beat your high score

---

## 🔧 What I Built

- **Player Jump Controller** — tap input triggers a physics-based jump, tuned for responsive feel on mobile
- **Obstacle Spawner** — obstacles spawn ahead at set intervals, scroll toward the player, and despawn off-screen
- **Collision & Game Over System** — hit detection triggers game over state, stops the run, and shows the restart screen
- **Score System** — score increments with survival time, personal best saved with PlayerPrefs

---

## 🧠 What I Learned

This was my first Unity project. Everything here was new — setting up a scene, writing C# scripts, connecting physics to input, managing game states. The lessons from this game became the foundation for every project I built after it.

- How Unity's physics and input systems work together
- Game state management — idle, playing, game over, restart
- Keeping a project scope small enough to actually finish and ship

---

## ⚙️ Tech

| Tool | Use |
|------|-----|
| Unity | Game engine |
| C# | Game logic |
| Rigidbody2D | Player physics |
| PlayerPrefs | High score persistence |

---

## 🚀 Run Locally

1. Clone: `git clone https://github.com/gameofbugs/Endless-runner`
2. Open in Unity Hub
3. Open the main scene and press Play

---

## 👤 About

Built solo by **Manoj S** — the first of 7 shipped Android Unity games.
More projects: [gameofbugsofficial.itch.io](https://gameofbugsofficial.itch.io)
