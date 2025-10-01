# Marble Maze – Physics Programming Project
**Studente:** Simone Giordano   

---

## Descrizione del progetto
Il progetto consiste in un livello 3D di tipo **Marble Maze**, sviluppato in **Unity** e basato interamente sul motore fisico del gioco.  

Il giocatore non controlla direttamente la pallina, ma **ruota il piano di gioco** lungo gli assi X e Z, influenzando lo spostamento della pallina tramite la forza di gravità.  
L’obiettivo è guidare la pallina attraverso un percorso pieno di ostacoli, evitando cadute e sfruttando trampolini e superfici fisiche fino a raggiungere la piattaforma finale che segnala la vittoria.  

---

## Funzionalità implementate
- **Controllo del piano di gioco**:
  - Rotazione lungo gli assi X e Z tramite input del giocatore.  
  - Movimento della pallina determinato esclusivamente dalla fisica (gravità, rigidbody, collider).  
- **Ostacoli e ambientazione**:
  - **Muri e ostacoli statici** con Box Collider.  
  - **Buchi (quadrati rossi)**: se la pallina cade, viene resettata alla posizione iniziale.  
  - **Trampolini (quadrati gialli)**: reagiscono alla direzione e forza dell’impatto, lanciando la pallina in aria in modo fisico.  
  - **Area di arrivo (quadrato verde)**: completa il livello e mostra un messaggio di vittoria.  

---

## Istruzioni per l’esecuzione
1. Aprire il progetto in **Unity**.  
2. Lanciare la scena principale del livello **MarbleMaze.unity**.  
3. Utilizzare i comandi per inclinare il piano e guidare la pallina fino all’area di arrivo.  

---

## Controlli
- **A/D o freccia direzionale dx/sx** – Ruota il piano sull’asse Z.  
- **W/S o freccia direzionale su/giu'** – Ruota il piano sull’asse X.  

---

##Video dimostrativo
[![Marble Maze Demo](https://img.youtube.com/vi/pBACTiE96PA/0.jpg)](https://youtu.be/pBACTiE96PA)

