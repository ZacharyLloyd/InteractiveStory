using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace InteractiveStory
{
    public partial class Form2 : Form
    {
        //Variable will be used for choices being made from the drop down
        int newChoice;
        //Vairable will be used for choices being made from drop down
        int fightOrFlight;
        //bool to see if sounds are playing
        bool isPlaying = false;
        //Create an object for playing zombie sounds
        SoundPlayer zombieSoundPlayer = new SoundPlayer(Properties.Resources.Enraged_Zombies);
        //Create an object for playing gun shot sounds
        SoundPlayer gunShotSoundPlayer = new SoundPlayer(Properties.Resources.AR_15_Gunfire);
        public Form2()
        {
            InitializeComponent();
            //Change the background image
            this.BackgroundImage = Properties.Resources.ZpmbieStoreFronts;
            //Continue Story button set false
            //Set the option menu 2 to false so it can not be used yet
            Option2ComboBox.Enabled = false;
            //Continue the story by giving the player instructions on what to do next
            StoryTextBox.Text = "Welcome to stage two you've made it this far. " +
                "Now that you have gotten out of the store you went to for supplies what would you like to do next? " +
                "Use the drop down to continue the story.";
        }
        private void Options1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            newChoice = Options1ComboBox.SelectedIndex;
            Decision();
        }
        private void Option2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fightOrFlight = Option2ComboBox.SelectedIndex;
            FightDecision();
        }
        //This method is used for the decision the player will make
        //Depending on what option they picked in the drop down will depend on what outcome they get
        private void Decision()
        {
            //If the player picks the first item in the drop down
            if (newChoice == 0)
            {
                //Show the first case in continuestory
                ContinueStory(1);
            }
            //If the player picks the second item in the drop down
            else if (newChoice == 1)
            {
                //Show the second case in continuestory
                ContinueStory(2);
            }
            //If the player picks the third item in the drop down
            else if (newChoice == 2)
            {
                //Show the third case in continuestory
                ContinueStory(3);
            }
        }
        private void ContinueStory(int index)
        {
            //Change background image to match zombiefight found in resource folder
            this.BackgroundImage = Properties.Resources.ZombieCity;
            //Tell the user they have looted everything and zombies are spotted
            StoryTextBox.Text = "You guys have gotten to the store and looted everything. Tom notices a horde of zombies approaching from the street.";
            //Switch for the different outcomes related to what decision the player has made
            switch (index)
            {
                //If the player has picked the first item in the drop down this is their story
                case 1:
                    //Display story
                    StoryTextBox.Text = "You have decided to search for more supplies. You notice a pharmacy across the street. " +
                        "This will be good to restock on some medical supplies since camp is running low. " +
                        "Upon entering the pharamacy you notice that it looks like it was recently scavenged. " +
                        "No one else from the camp was told to go search for supplies, you realize that this could be a different group. " +
                        "You proceed with caution to leave the pharmacy and try and find somewhere else to find supplies. " +
                        "You go across the street to a gun store to try and find some ammo. " +
                        "As you enter the gun store your group gets shot at from a building across the street. " +
                        "You are now in a pinch do you fight them and risk dying or more zombies coming or do you run? " +
                        "Use the fight or flight option to make a decision.";
                    //Allow the player to use this combo box now
                    Option2ComboBox.Enabled = true;
                    //Play gunshot sound
                    gunShotSoundPlayer.PlayLooping();
                    //change bool to true
                    isPlaying = true;
                    break;
                //If the player has picked the second item in the drop down this is their story
                case 2:
                    //Display Story
                    StoryTextBox.Text = "You have decided to return to camp. You make it down the street and think all of you are getting away. " +
                        "You turn a street corner and see a massive amount of zombies in the street. " +
                        "You realize that it is going to be difficult to get through them. " +
                        "You notice an ally way that you could run through and completely avoid the horde. " +
                        "You have a good amount of supplies on you that your camp could deffinitely use. " +
                        "Do you want to fight through the horde to get back to camp or take the ally way and ensure that you get back safely? " +
                        "Use the fight or flight option to make a decision.";
                    //Allow the player to use this combo box now
                    Option2ComboBox.Enabled = true;
                    break;
                //If the player has picked the third item in the drop down this is their story
                case 3:
                    //Display story
                    StoryTextBox.Text = "You have decided to go on a zombie killing rampage. " +
                        "All of you check your mags and get ready to go on a killing rampage. " +
                        "You all move out as a group covering a 360 degree angle ensuring nothing will sneak up on you. " +
                        "You see the horde and start shooting. " +
                        "The zombies are dropping like flies but the more shots you guys take the more zombies keep coming. " +
                        "You are realizing that you are going to run out of ammo soon. " +
                        "Do you want to continue your rampage and fight to the death or do you want to try and run away? " +
                        "Use the fight or flight option to make a decision.";
                    //Allow the player to use this combo box now
                    Option2ComboBox.Enabled = true;
                    //Play zombie sound
                    zombieSoundPlayer.Play();
                    //Play gunshot sound
                    gunShotSoundPlayer.PlayLooping();
                    //change bool to true
                    isPlaying = true;
                    break;
            }
        }
        //This method is used for the decision the player will make
        //Depending on what option they picked in the drop down will depend on what outcome they get
        private void FightDecision()
        {
            //If the player picks the first item in the drop down
            if (fightOrFlight == 0)
            {
                //Show the first case in continuestory
                EndStory(1);
            }
            //If the player picks the second item in the drop down
            else if (fightOrFlight == 1)
            {
                //Show the second case in continuestory
                EndStory(2);
            }
        }
        private void EndStory(int index)
        {
            switch (index)
            {
                //If the player has picked the first item in the drop down this is their story
                case 1:
                    //if the player selected to go look for more supplies
                    if (newChoice == 0)
                    {
                        //Display story
                        StoryTextBox.Text = "You have decided to fight. " +
                            "You see where you are getting shot from now. " +
                            "You tell Tom to get an angle on the guy shooting at you guys while you and Suzie lay down cover fire. " +
                            "Tom is able to get the angle and take down the shooter. " +
                            "The issue now is that the zombies are closing in on you and you are stuck in a store. " +
                            "You all are low on ammo and realize that there is no way out from here. " +
                            "You load your last mag and say a dying prayer. " +
                            "This is the end. " +
                            "You all have died.";
                        //change background image
                        this.BackgroundImage = Properties.Resources.ZombieFight;
                        //play zombie sound
                        zombieSoundPlayer.Play();
                        //play gunshot sound
                        gunShotSoundPlayer.PlayLooping();
                        //Thank the player for playing and that they can now exit
                        MessageBox.Show("Thank you for playing the simulation is now over you may exit the application now");
                    }
                    //if the player selected to go back to camp
                    else if (newChoice == 1)
                    {
                        StoryTextBox.Text = "You have decided to fight. " +
                            "You guys start making progress down the street clearing your way through the zombies. "+
                            "You realize though that zombies are starting to come behind you. "+
                            "There is not going to be a way out of this your ammo was already low. "+
                            "The three of you decide to fight back to back to go down as a group. "+
                            "You guys take as many as you can but you are overwhelemed. "+
                            "All of you have died.";
                        //change background image
                        this.BackgroundImage = Properties.Resources.ZombieFight;
                        //play zombie sound
                        zombieSoundPlayer.Play();
                        //play gunshot sound
                        gunShotSoundPlayer.PlayLooping();
                        //Thank the player for playing and that they can now exit
                        MessageBox.Show("Thank you for playing the simulation is now over you may exit the application now");
                    }
                    //if the player selected to go on a zombie killing rampage
                    else if (newChoice == 2)
                    {
                        StoryTextBox.Text = "You have decided to fight. " +
                            "You guys are sick of these creatures ruining lives and are enraged. "+
                            "You guys do not care that you are almost out of ammo. "+
                            "All you guys can do now is take as many down as you can before they take you down. "+
                            "The three of you are back to back firing non stop. "+
                            "You all realize this is the end as you run out of ammo and say your dying words. "+
                            "You all faught well but have all died.";
                        //change background image
                        this.BackgroundImage = Properties.Resources.ZombieFight;
                        //play zombie sound
                        zombieSoundPlayer.Play();
                        //play gunshot sound
                        gunShotSoundPlayer.PlayLooping();
                        //Thank the player for playing and that they can now exit
                        MessageBox.Show("Thank you for playing the simulation is now over you may exit the application now");
                    }
                    break;
                //If the player has picked the second item in the drop down this is their story
                case 2:
                    //if the player selected to go look for more supplies
                    if (newChoice == 0)
                    {
                        if (isPlaying == true)
                        {
                            gunShotSoundPlayer.Stop();
                        }
                        //Display Story
                        StoryTextBox.Text = "You have decided to run. " +
                            "You lay down cover fire to get Tom and Suzie to safety. " +
                            "Once they are safe they lay down cover fire for you to get out. " +
                            "You notice an ally way that you could run through and completely avoid everything. " +
                            "Once you get to the ally the decision to just go back to camp is made. " +
                            "You have enough supplies for camp to use and your lives are more important than finding more supplies. " +
                            "You arrive safely back to camp.";
                        //Change background image
                        this.BackgroundImage = Properties.Resources.ZombieCamp;
                        //Thank the player for playing and that they can now exit
                        MessageBox.Show("Thank you for playing the simulation is now over you may exit the application now");
                    }
                    //if the player selected to go back to camp
                    else if(newChoice == 1)
                    {
                        StoryTextBox.Text = "You have decided to run. " +
                            "You take the ally way to avoid all of the zombies that were in your way. " +
                            "You guys deffinitely spared your lives by making this choice. " +
                            "You get to the outskirts of the city making sure everyone is okay and that you still have the supplies. " +
                            "Upon checking everything is good and you make your way back to camp. " +
                            "You arrive at camp and are thanked for the supplies.";
                        //Change background image
                        this.BackgroundImage = Properties.Resources.ZombieCamp;
                        //Thank the player for playing and that they can now exit
                        MessageBox.Show("Thank you for playing the simulation is now over you may exit the application now");
                    }
                    //if the player selected to go on a zombie killing rampage
                    else if(newChoice == 2)
                    {
                        if (isPlaying == true)
                        {
                            gunShotSoundPlayer.Stop();
                        }
                        StoryTextBox.Text = "You have decided to run. " +
                            "As try and run away you guys are still getting swarmed and need to protect each other. "+
                            "Suzie is falling behind though and you realize that she is not going to make it. "+
                            "Tom tries to save her but it is too late and she is already being overwhelmed falling to the ground."+
                            "You tell Tom to come back but he insists on saving her. "+
                            "You realize there is nothing you can do and as this decision is made you see Tom get overwhelmed as well. "+
                            "Fearing for you own life you run as fast as you can to get away."+
                            "You manage to make it out of the city but a lot of supplies were lost. "+
                            "Eventually you make it back to camp and are questioned as to what happened. "+
                            "You tell them what has happened and are relieved you atleast made it out. "+
                            "You are told to get some rest and that tomorrow will be a better day.";
                        //Change background image
                        this.BackgroundImage = Properties.Resources.ZombieCamp;
                        //Thank the player for playing and that they can now exit
                        MessageBox.Show("Thank you for playing the simulation is now over you may exit the application now");
                    }
                    break;
            }
        }
    }
}
