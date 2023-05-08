# Diploma Project - GPT

![Completion status: On-Going](https://img.shields.io/badge/COMPLETION%20STATUS-ON--GOING-blue?style=for-the-badge)


## Introduction

This report documents the experience of my colleagues and me in using ChatGPT 3.5, a natural language processing (NLP) model developed by OpenAI, for scripting assistance in our sixth college term final assignment. Our task was to create a video game that promotes Indonesian tourist attractions, and we chose to develop a top-down game called "Petualangan Danau Toba," which showcases one of the famous North Sumatra tourist destinations, Toba Lake.

In this report, we share our experience of working with ChatGPT 3.5, how we used it to create the game, and what challenges we faced during the development process.

### Game Overview

"Petualangan Danau Toba" is a top-down game that takes place in Toba Lake, North Sumatra, Indonesia. The game's objective is to promote Indonesian tourism and educate players about Toba Lake's natural beauty and cultural significance. The game consists of several mini-games, including a slider mini-game and a taking photos mini-game, which challenge players to interact with the game environment and learn about the lake's various features.

To illustrate more about the game, we have provided a demo video of the game that you can see below (though, as you might notice, the game in the demo video was not finished yet, it covered all the necessary functionalities):

![demo](images/demo.gif)<br>

### Scripting

We decided to use ChatGPT 3.5 as a scripting assistance tool to save time and streamline the documentation process. Our goal was to create game scripts based on the specifications we provided, and then manually tweak the code as needed to fit our requirements.

**1. Main Menu**

We began by creating components for the main menu scene, which consisted of three components in total. The first two scripts were related to a prologue system, as shown below. <br> <br>

![conversation](images/conversation/1/1-a.png)
![conversation](images/conversation/1/1-b.png)
![conversation](images/conversation/1/1-c.png)
![conversation](images/conversation/1/1-d.png)
![conversation](images/conversation/1/1-e.png) <br><br>

As you can see, the AI generated scripts met our specifications. However, it did include an unnecessary variable that we hadn't requested, the "title" variable in the PrologueData class. We manually removed it and proceeded.

Next, we asked the AI to create a scene loader component that would play an animation and load a scene after the animation finished.<br><br>

![conversation](images/conversation/1/3-a.png)
![conversation](images/conversation/1/3-b.png)
![conversation](images/conversation/1/3-c.png)
<br><br>

Once the AI generated the script, we then requested it to make the prologue system call a method in the scene loader when the player completed showing all of the prologue data.
<br><br>

![conversation](images/conversation/1/4-a.png)
![conversation](images/conversation/1/4-b.png)
![conversation](images/conversation/1/4-c.png)
![conversation](images/conversation/1/4-d.png)
<br><br>

After updating the prologue system, we tested the scripts and discovered an error.
<br><br>

![conversation](images/conversation/1/5-a.png)<br><br>

To test the AI's capability to solve an error, we asked it to fix the script based on our assumption that the error was due to a misplaced code or incorrect code execution order. However, the AI updated the script with additional code that we didn't mention.<br><br>

![conversation](images/conversation/1/6-a.png)
![conversation](images/conversation/1/6-b.png)
![conversation](images/conversation/1/6-c.png)
<br><br>

Although the added code was acceptable, we speculated that the previous request sentence was ambiguous and contained grammatical errors, leading to the AI's incorrect interpretation. So we tried again with a more precise request.<br><br>

![conversation](images/conversation/1/7-a.png)
![conversation](images/conversation/1/7-b.png)
![conversation](images/conversation/1/7-c.png)
![conversation](images/conversation/1/7-d.png)
<br><br>

Finally, the AI generated the correct code, and we were satisfied with the results. We marked this section as completed.

**2. Slider Mini-Game**

After completing the main menu scene, our team moved on to designing the in-game components. The first component we created was the slider mini-game. This mini-game involved a slider whose value moved infinitely back and forth. The player had to stop the slider value within a random range by using the K keyboard button. <br><br>

![conversation](images/conversation/2/1-a.png)
![conversation](images/conversation/2/1-b.png)
![conversation](images/conversation/2/1-c.png)
![conversation](images/conversation/2/1-d.png)
![conversation](images/conversation/2/1-e.png)
<br><br>

We were impressed with the AI's response as it fulfilled all our requirements. However, we wanted to take the mini-game a step further and add a visualization of the random range. We asked the AI for its input on this.<br><br>

![conversation](images/conversation/2/2-a.png)
![conversation](images/conversation/2/2-b.png)
![conversation](images/conversation/2/2-c.png)
![conversation](images/conversation/2/2-d.png)
![conversation](images/conversation/2/2-e.png)
<br><br>

The AI's idea was close to what we wanted, but it didn't quite meet our needs. So, we asked it to make some changes to the code.<br><br>

![conversation](images/conversation/2/3-a.png)
![conversation](images/conversation/2/3-b.png)
![conversation](images/conversation/2/3-c.png)
![conversation](images/conversation/2/3-d.png)
![conversation](images/conversation/2/3-e.png)
![conversation](images/conversation/2/3-f.png)
<br><br>

Unfortunately, things went wrong from here. The AI put the visualization code in the update loop, making it dependent on the slider value and causing it to move back and forth with the slider. Upon reviewing the conversation, we realized that the fault might have been due to the ambiguity of our initial command. We clarified the command and asked the AI to make the necessary changes.<br><br>

![conversation](images/conversation/2/4-a.png)
![conversation](images/conversation/2/4-b.png)
![conversation](images/conversation/2/4-c.png)
![conversation](images/conversation/2/4-d.png)
![conversation](images/conversation/2/4-e.png)
![conversation](images/conversation/2/4-f.png)
<br><br>

Thankfully, the AI responded with the correct code. We then moved on to adding a difficulty level to the mini-game. We wanted to decrease the random range distance based on the number of successful attempts made by the player. We asked the AI to implement this feature.<br><br>

![conversation](images/conversation/2/5-a.png)
![conversation](images/conversation/2/5-b.png)
![conversation](images/conversation/2/5-c.png)
![conversation](images/conversation/2/5-d.png)
![conversation](images/conversation/2/5-e.png)
<br><br>

However, the AI made some changes to the code that we did not mention, causing it to be incorrect. We asked the AI to fix the code.<br><br>

![conversation](images/conversation/2/6-a.png)
![conversation](images/conversation/2/6-b.png)<br><br>

Finally, the AI provided us with the correct code that met our requirements, and we marked this part of the project as completed.

**3. Character**

In this phase, we developed the character components and our custom event system. Our first task was to ask the AI to create a component that would give the character basic movement and intersection handling. <br><br>

![conversation](images/conversation/3/1-a.png)
![conversation](images/conversation/3/1-b.png)
![conversation](images/conversation/3/1-c.png)
<br><br>

As expected, the AI delivered the desired component without any issues. Next, we asked it to create a component for our event system and incorporate the observer design pattern. <br><br>

![conversation](images/conversation/3/2-a.png)
![conversation](images/conversation/3/2-b.png)
![conversation](images/conversation/3/2-c.png)
![conversation](images/conversation/3/2-d.png)
<br><br>

Again, the AI met our requirements, but here we wanted to use a different data type for the text UI, so we made the changes manually. Moving forward, we requested the AI to modify the character's intersection handling to use our event system<br><br>

![conversation](images/conversation/3/5-a.png)
![conversation](images/conversation/3/5-b.png)
![conversation](images/conversation/3/5-c.png)
<br><br>

Although the AI produced codes that met our requirements, it removed the character's movement ability. We had to request that the AI add the movement ability back.
<br><br>

![conversation](images/conversation/3/6-a.png)
![conversation](images/conversation/3/6-b.png)
<br><br>

The AI added the movement ability back, but with a different algorithm, which was acceptable to us. In the next conversation, we asked the AI to make the character script trigger specific events when it left an intersection. However, due to a miscommunication or an unclear command, the AI made unnecessary changes to the codes.<br><br>

![conversation](images/conversation/3/8-a.png)
![conversation](images/conversation/3/8-b.png)
![conversation](images/conversation/3/8-c.png)
![conversation](images/conversation/3/8-d.png)
![conversation](images/conversation/3/8-e.png)
<br><br>

The AI mistakenly added the exiting intersection handling in the event system instead of the character, and it changed the character's movement method for no apparent reason. We had to request that the AI revert the codes to their previous state.
<br><br>

![conversation](images/conversation/3/9-a.png)
<br><br>

Strangely, the AI refused to comply with our request, possibly due to a misunderstanding of our command. Therefore, we made a more explicit request, and the AI responded with the rollback codes, along with the necessary changes we had requested earlier.
<br><br>

![conversation](images/conversation/3/10-a.png)
![conversation](images/conversation/3/10-b.png)
![conversation](images/conversation/3/10-c.png)
![conversation](images/conversation/3/10-d.png)
![conversation](images/conversation/3/10-f.png)
![conversation](images/conversation/3/10-e.png)
<br><br>

Overall, we were satisfied with the completed codes and marked this section as completed.

**4. Taking a photo**

Taking a photo from a photo spot was one of the core gameplay elements in our game. To implement this, we created components specifically for this feature. Our first step was to create a script that would store all the photos taken by the player.<br><br>

![conversation](images/conversation/4/1-a.png)
![conversation](images/conversation/4/1-b.png)
<br><br>

In the initial conversation with the AI, it generated a script correctly, but we wanted to add some naming conventions and asked the AI to revise the script accordingly. <br><br>

![conversation](images/conversation/4/1-c.png)
![conversation](images/conversation/4/1-d.png)
<br><br>

Next, we wanted to integrate the event system we made for the slider mini-game. However, we encountered many trial-and-error attempts with the AI while trying to do this. We found that the AI struggled with memorizing codes, even those it had generated not too long ago. To overcome this challenge, we came up with a new approach to include codes while asking for revisions or creations that required reference to previously generated codes. We also used this approach in a few upcoming conversations.<br><br>

![conversation](images/conversation/4/2-a.png)
![conversation](images/conversation/4/2-b.png)
![conversation](images/conversation/4/2-c.png)
![conversation](images/conversation/4/2-d.png)
![conversation](images/conversation/4/2-e.png)
![conversation](images/conversation/4/2-f.png)
![conversation](images/conversation/4/2-g.png)
![conversation](images/conversation/4/2-h.png)
![conversation](images/conversation/4/2-i.png)
![conversation](images/conversation/4/2-j.png)
![conversation](images/conversation/4/2-k.png)
<br><br>

In our first attempt to use this approach, the AI updated the script to our specifications, and it worked correctly. However, the conversation became too long while using this approach, so we truncated parts of the conversation in our subsequent attempts.<br><br>

![conversation](images/conversation/4/3-a.png)
![conversation](images/conversation/4/3-b.png)
![conversation](images/conversation/4/3-c.png)
![conversation](images/conversation/4/3-d.png)
![conversation](images/conversation/4/3-e.png)
![conversation](images/conversation/4/3-f.png)
![conversation](images/conversation/4/3-g.png)
![conversation](images/conversation/4/3-h.png)
<br><br>

We then asked the AI to store photo data when the player successfully finished playing the slider mini-game. The AI generated codes that had the features we wanted but used an undefined singleton variable from the PhotoStorage class, which led to a compiler error. We informed the AI about this issue, and it subsequently implemented the singleton design pattern in the PhotoStorage class.<br><br>

![conversation](images/conversation/4/4-a.png)
![conversation](images/conversation/4/4-b.png)
![conversation](images/conversation/4/4-c.png)
![conversation](images/conversation/4/4-d.png)
<br><br>

We also imported the Rotary Heart Unity package and requested the AI to change the data type of the variable that stored photo data to the serializable dictionary data type, which was included in the package. Surprisingly, the AI was able to convert the data type correctly, even though it was from an external package. The AI also updated the codes that used this variable to match the new data type.<br><br>

![conversation](images/conversation/4/5-a.png)
![conversation](images/conversation/4/5-b.png)
![conversation](images/conversation/4/5-c.png)
![conversation](images/conversation/4/5-d.png)
<br><br>

Our next step was to create UI scripts that showed all the photos that could be collected by the player in the game. <br><br>

![conversation](images/conversation/4/7-a.png)
![conversation](images/conversation/4/7-b.png)
![conversation](images/conversation/4/7-c.png)
![conversation](images/conversation/4/7-d.png)
<br><br>

We then asked the AI to make a script that highlighted a photo in the previous UI and add a method in the AlbumItem class that would connect the class with the script.<br><br>

![conversation](images/conversation/4/8-a.png)
![conversation](images/conversation/4/8-b.png)
![conversation](images/conversation/4/8-c.png)
![conversation](images/conversation/4/8-d.png)
<br><br>

Here, the AI returned with codes doing the jobs we specified. But there was one thing that made the codes slightly wrong, which was the way to reference the highlightedAlbumItem class. We then asked the AI to implement the singleton design pattern as the revision.
<br><br>

![conversation](images/conversation/4/9-a.png)
![conversation](images/conversation/4/9-b.png)
![conversation](images/conversation/4/9-c.png)
![conversation](images/conversation/4/9-d.png)
<br><br>

Finally, we requested the AI to create a script that would pop up a UI whenever the player completed playing the slider mini-game and took a photo corresponding to that specific mini-game session. The AI generated codes that were very close to our requirements, but it forgot to include something we had mentioned in the conversation. We added this feature manually to the codes. We also added codes to the SliderMiniGame class to show the popup UI when the player completed three success counts in the slider mini-game. With that, we marked this part as completed.
<br><br>

![conversation](images/conversation/4/10-a.png)
![conversation](images/conversation/4/10-b.png)
![conversation](images/conversation/4/10-c.png)
<br><br>

**5. Dialogue**

Our next focus was on implementing a dialogue system. To start, we created the necessary scriptable object scripts. The AI was able to produce the scripts exactly as we needed.<br><br>

![conversation](images/conversation/5/1-a.png)
![conversation](images/conversation/5/1-b.png)
![conversation](images/conversation/5/1-c.png)<br><br>

We then asked the AI to create the main script for the dialogue system, and it was delivered without any issues.<br><br>

![conversation](images/conversation/5/2-a.png)
![conversation](images/conversation/5/2-b.png)
![conversation](images/conversation/5/2-c.png)
![conversation](images/conversation/5/2-d.png)<br><br>

Next, we wanted to integrate the event system we had developed earlier with the new dialogue system. This would allow the dialogue system to display the appropriate data that was passed to the event system.<br><br>

![conversation](images/conversation/5/3-a.png)
![conversation](images/conversation/5/3-d.png)
![conversation](images/conversation/5/3-e.png)
![conversation](images/conversation/5/3-f.png)
![conversation](images/conversation/5/3-g.png)<br><br>

The AI updated the event system script as per our requirements. However, in the process, it assumed that the dialogue system implemented the singleton design pattern. As a result, the event system referred to a non-defined variable. Despite this issue, we liked the singleton pattern and requested the AI to implement it in the dialogue system instead.<br><br>

![conversation](images/conversation/5/4-a.png)
![conversation](images/conversation/5/4-b.png)
![conversation](images/conversation/5/4-c.png)
![conversation](images/conversation/5/4-d.png)
![conversation](images/conversation/5/4-e.png)<br><br>

To implement the dialogue system, we required an NPC behavior script. So, we asked the AI to create a simple version of this script that had a variable to store dialogue data.<br><br>

![conversation](images/conversation/5/5-a.png)
![conversation](images/conversation/5/5-b.png)<br><br>

We then integrated the main character script we had previously created with the newly created NPC behavior script. This allowed the main character to pass dialogue data to the event system via the NPC behavior.<br><br>

![conversation](images/conversation/5/6-a.png)
![conversation](images/conversation/5/6-c.png)
![conversation](images/conversation/5/6-d.png)
![conversation](images/conversation/5/6-e.png)<br><br>

As we progressed, we asked the AI to update the dialogue system to enable it to display images in full screen.<br><br>

![conversation](images/conversation/5/7-a.png)
![conversation](images/conversation/5/7-c.png)
![conversation](images/conversation/5/7-d.png)
![conversation](images/conversation/5/7-e.png)
![conversation](images/conversation/5/7-f.png)
![conversation](images/conversation/5/7-g.png)<br><br>


To implement the image display functionality, we utilized the callback function in the dialogue data scriptable object. Since this function was called in the middle of showing dialogue data, it was perfect for our needs. We then requested the AI to create scriptable object scripts that inherited the data type of this callback function. We also asked the AI to make a dialogue callback that set the activation of a game object.<br><br>

![conversation](images/conversation/5/8-a.png)
![conversation](images/conversation/5/8-b.png)
![conversation](images/conversation/5/8-c.png)<br><br>

The AI provided us with the required scripts that met our specifications. However, we overlooked something important about Unity - the impossibility of finding game objects based on their names in plural form. So, we asked the AI to modify the corresponding script.<br><br>

![conversation](images/conversation/5/9-a.png)
![conversation](images/conversation/5/9-b.png)
![conversation](images/conversation/5/9-c.png)<br><br>

Overall, we completed the implementation of the dialogue system.

**6. Quest**

In this phase, we delved into creating a quest system for our project. We started by developing scriptable object scripts that were necessary for this system. The AI did an excellent job of scripting as we wanted.
<br><br>

![conversation](images/conversation/6/1-a.png)
![conversation](images/conversation/6/1-b.png)
![conversation](images/conversation/6/1-c.png)<br><br>

Moving forward, we created a core implementation script for the quest system, which stored the progress of a quest and updated it based on in-game events. We also designed a UI script that displayed the quest progress data contained in that script.<br><br>

![conversation](images/conversation/6/2-a.png)
![conversation](images/conversation/6/2-b.png)
![conversation](images/conversation/6/2-c.png)
![conversation](images/conversation/6/2-d.png)
![conversation](images/conversation/6/2-e.png)
![conversation](images/conversation/6/2-f.png)
![conversation](images/conversation/6/2-g.png)
![conversation](images/conversation/6/2-h.png)<br><br>

To make the quest progress more interactive, we added a variable to the event system script that triggered whenever an in-game event proceeded.<br><br>

![conversation](images/conversation/6/3-a.png)
![conversation](images/conversation/6/3-c.png)
![conversation](images/conversation/6/3-d.png)
![conversation](images/conversation/6/3-e.png)
![conversation](images/conversation/6/3-f.png)
![conversation](images/conversation/6/3-g.png)<br><br>

Furthermore, we asked the AI to create a script that showed a popup UI to the player to indicate the addition or completion of a quest. <br><br>

![conversation](images/conversation/6/8-a.png)
![conversation](images/conversation/6/8-b.png)
![conversation](images/conversation/6/8-c.png)<br><br>

We then requested the AI to update the quest progress script to implement this UI script.<br><br>

![conversation](images/conversation/6/9-a.png)
![conversation](images/conversation/6/9-e.png)<br><br>

We wanted the NPC component to trigger the quest progress component's methods and store the progress, so we asked the AI to update the NPC component accordingly. We also asked the AI to make the NPC component have a notification UI that indicated the state of the quest progress in it.<br><br>

![conversation](images/conversation/6/4-a.png)
![conversation](images/conversation/6/4-f.png)
![conversation](images/conversation/6/4-g.png)
![conversation](images/conversation/6/4-h.png)<br><br>

To initiate a quest, we requested the AI to create a scriptable object script that inherited the DialogueCallback class. This script started a quest from the callback functionality of a dialogue.<br><br>

![conversation](images/conversation/6/5-a.png)
![conversation](images/conversation/6/5-g.png)
![conversation](images/conversation/6/5-h.png)<br><br>

Next, we asked the AI to create the requirements of a quest completion function in the NPC class, making the entire quest system more robust and interactive.<br><br>

![conversation](images/conversation/6/6-a.png)
![conversation](images/conversation/6/6-f.png)
![conversation](images/conversation/6/6-g.png)
![conversation](images/conversation/6/6-h.png)
![conversation](images/conversation/6/6-i.png)<br><br>

Lastly, we asked the AI to create a dialogue callback scriptable object script that completed a quest, which removed the quest progress in an NPC component.<br><br>

![conversation](images/conversation/6/7-a.png)
![conversation](images/conversation/6/7-e.png)<br><br>

Throughout this phase, as you might have noticed, we had encountered fewer problems with the AI, which made us prompt fewer commands and be more comfortable using it. We completed this part with great success, and we are pleased with the outcome.

**7. NPC Navigation**

We've tackled another important aspect of our game development: NPC navigation. With the help of AI, we created a scriptable object script and updated the NPC component to have a navigation system.<br><br>

![conversation](images/conversation/7/1-a.png)
![conversation](images/conversation/7/1-b.png)
![conversation](images/conversation/7/1-f.png)
![conversation](images/conversation/7/1-g.png)
![conversation](images/conversation/7/1-h.png)
![conversation](images/conversation/7/1-i.png)
![conversation](images/conversation/7/1-j.png)
![conversation](images/conversation/7/1-k.png)
![conversation](images/conversation/7/1-l.png)<br><br>

While the AI did return a script that included all the necessary functionality, it also had some missing namespace statements. Despite this minor setback, we were still able to achieve our desired outcome by manually fixing the code ourselves.

### Conclusion

In conclusion, our experience of using ChatGPT as a scripting assistant for this project has been both enlightening and productive. Although it may take some time to get used to, once you understand the basics of how it works, the AI can significantly improve your productivity by automating many of the tedious and repetitive coding tasks.

**Pros & Cons**

Based on our experience, we have identified some pros and cons of using ChatGPT as a scripting assistant:

Pros:

- Easy to generate boilerplate codes quickly.
- Capable of handling mathematical equations and implementing design patterns.
- Can incorporate external packages into your code.
- Might surprise you with creative ideas that you couldn't even imagine.

Cons:

- Has difficulty remembering previous conversations and context.
- Inconsistent with naming conventions and data types.
- Generates unnecessary variables and safety checks. 
- Crafting commands may be time-consuming.


**Tips & Tricks**

To make the most of ChatGPT as a scripting assistant, here are some tips and tricks we found useful:

- Create a UML diagram beforehand to ensure a clear understanding of the project's structure.
- Break down commands into a list of concise, specific requests.
- Specify the names and data types of variables explicitly.
- Use the "regenerate response" feature if the AI response is not satisfactory.
- Pass the script of a class whenever you need to update or do another activity referring to that class.
- Avoid grammatical errors to improve the AI's comprehension.

Overall, ChatGPT has proven to be a valuable tool for our scripting needs, and we look forward to exploring its capabilities further in future projects.