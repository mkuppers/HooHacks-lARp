### _"The hardest part about exercise is to start doing it. Once you are doing exercise regularly, the hardest part is to stop it."  - Erin Grey_

We make it easy to start. 

Welcome to **lARp**, a mushroom-themed AR fitness game that promotes physical activity through gamification, incentivizing you to use the outdoors as your gym to become the buff mushroom man of your dreams. 💪

 
# Features

![gif for talking](https://im2.ezgif.com/tmp/ezgif-2-f85d9051e9c5.gif)
**1. Limitless narrative possibilities.** Utilizing GPT-3 to allow players to say whatever they want to characters, random character generation and featuring over 9,000+ unique mushrooms, every game you play will be different, allowing the player to craft unique and memorable stories about the adventures they go on.

**2. Fight or befriend mushrooms along the way!**
**3. Achieve your fitness dreams.** Complete missions with difficulty based on step count, and work towards your health goal while earning gear to customize your mushroom warrior!


# How lARp Was Built

*lARp* was built by a mixed team of designers and developers - all with varying levels of game design experience. 

*lARp*'s _design_ was created through an iterative approach in assessing features in sketching, low-fidelity and mid-fidelity prototyping before creating a final prototype to build. Our designers and developers worked closely to ensure the prototype and UI elements aligned with the implementation of the features.

*lARp*'s tech was primarily built through ARFoundation and Unity, and the dialogue generation was implemented using OpenAI GPT-3. 

View our process documentation below. 

## Design
### UI/UX
![wireframes](https://i.imgur.com/GyB8aZF.jpg)
We began by creating wireframes of our application in Google Jamboard, jotting down our ideas for the screens to prioritize creating, essential features, and potential screen layouts. We also created a user journey map to better understand how a user might experience the app. 

![lo-fi and mid-fi](https://i.imgur.com/JPGsKas.jpg)

### Character Design
![inspiration](https://i.imgur.com/bHNABCV.jpg)
We drew inspiration for mushrooms through games like Maplestory, and from Nancy's wealth of mushroom knowledge from her obsession with mushrooms. 

### Design Guide
![design guide](https://i.imgur.com/sVP1GBs.jpg)

![ui elements](https://i.imgur.com/TRotgjz.jpg)

### Technical Design and Implementation
lARp was built in Unity and because of that we used ARFoundation to handle the AR aspect and C# to handle all programming. The most novel part of programming this project was random generation + GPT-3. Each time you encounter a character, we create them from a pool of personalities, body parts, and descriptions. Because of this we have a total of 9702 possible characters at the moment but we could easily expand that number further. One of the fun aspects of working with GPT-3 is it will respond to quite literally _anything_ so beyond just getting it to work in Unity, we had to manage giving it good prompts and descriptions so that way we would get output to better match our setting. Allowing players to talk about literally anything they want with the NPCs is a really cool mechanic and lends well to roleplaying.
Another technical challenge was getting a working pedometer in Unity. We found someone made a pedometer API but it was less than stellar and we constantly had to find workarounds to get it to work. The reason we chose to track player movement on a pedometer rather than GPS as Pokemon Go does was that this would allow treadmill players to play our game as well. You shouldn't be penalized or need to take a break for bad weather.


## Technologies 
- **AR:** Unity 3D, C#, ARFoundation
- **AI:** OpenAI (GPT-3)
- **3D Modeling/Animation/Rotoscoping:** Autodesk Maya, Unity 3D, Adobe Photoshop
- **UI/UX/Graphics:** Adobe Photoshop, Figma
- **Collaboration:** Google Jamboard, Discord, Github

## Challenges We Ran Into
- Switching from using textured planes to sprites
- Creating effective prompts for GPT-3
- Generating good content
- Integrating GPT-3 with Unity
- Getting an accurate count of steps with the pedometer

## Accomplishments We're Proud Of
- Developing a fully functional mobile app
- Creating random generation for mushroom characters, allowing for a lot of permutations
- Finding (then struggling with) a pedometer API in Unity
- Making pixel art for an AR project
- Getting GPT-3 to work with Unity
- Having fun and questionable conversations with the AI
- Making an animated thumbnail
- Drawing a lot of mushrooms

## What We Learned
**Mushrooms**
- GPT-3 fills us with existential dread

## What's Next for lARp
- iOS Support (works with the exception of the pedometer)
- Multiplayer support (so people can go on quests together)
- Advertisement based monetization

## Project Credits/Citations
- Technologies: [OpenAI in Unity (Open Source)](https://github.com/ivomarel/OpenAI_Unity) | [NatStep: Pedometer API](https://github.com/natsuite/NatStep)
- Fonts: ["Klik", by Fenotype](https://www.dafont.com/klik.font) |  ["Basko Sapi", by Locomotype](https://www.dafont.com/bakso-sapi.font)
- Music: [Komiku - Mushrooms](https://freemusicarchive.org/music/Komiku/Captain_Glouglous_Incredible_Week_Soundtrack/bibliothque)
- Art References: [Running Lifeguard](https://tenor.com/view/lifeguard-muscular-guy-jogging-baywatch-bodybuilder-gif-16263779) | [Flaticon](https://www.flaticon.com/) | [The Noun Project: Running Icon by AdbA Icons](https://thenounproject.com/search/?q=running&i=1425530)
