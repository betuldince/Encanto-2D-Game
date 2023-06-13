using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Subtitles : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI m_Object;
    public FollowPath fp;
    void Start()
    {

      //  StartCoroutine(TheSequence());
    }

   IEnumerator TheSequence()
    {
         
            m_Object.text = "Morning Abuelo";
            yield return new WaitForSeconds(11);
            m_Object.text = "Hey! When's the magic Gift happen?";
            yield return new WaitForSeconds(2);
            m_Object.text = "My cousin's ceremony is tonight.";
            yield return new WaitForSeconds(2);
            m_Object.text = "What's his Gift?";
            yield return new WaitForSeconds(1);
            m_Object.text = "We're gonna find out!";
            yield return new WaitForSeconds(1);
            m_Object.text = "What's your Gift?";
            yield return new WaitForSeconds(2);
            m_Object.text = "Who's asking?";
            yield return new WaitForSeconds(1);
            m_Object.text = "Us!";
            yield return new WaitForSeconds(1);
            m_Object.text = "Well, us, I can't just talk about myself.";
            yield return new WaitForSeconds(2);
            m_Object.text = "I'm only part of the amazing Madrigals.";
            yield return new WaitForSeconds(3);
            m_Object.text = "Who's all the amazing Madrigals?";
            yield return new WaitForSeconds(2);
            m_Object.text = "Ah, you're not gonna leave me alone, are you?";
            yield return new WaitForSeconds(2);
            m_Object.text = "Casita, help me out.";
            yield return new WaitForSeconds(1.4f);
            //works fine
            m_Object.text = "Drawers!";
            yield return new WaitForSeconds(1.7f);
            m_Object.text = "Floors!";
            yield return new WaitForSeconds(1.5f);
            m_Object.text = "Doors!";
            yield return new WaitForSeconds(1.6f);
            m_Object.text = "Let's go!";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "This is our home. We've got every generation.";
            yield return new WaitForSeconds(3);
            m_Object.text = "So full of music. A rhythm of its own design.";
            yield return new WaitForSeconds(3.3f);
            m_Object.text = "This is my family. A perfect constellation.";
            yield return new WaitForSeconds(3.6f);
            //fine

            m_Object.text = "So many stars. And everybody gets to shine.";
            yield return new WaitForSeconds(3.1f);
            m_Object.text = "Whoa";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "But let's be clear. Abuela runs this show. ";
            yield return new WaitForSeconds(2.5f);
            m_Object.text = "Whoa";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "She led us here. So many years ago.";
            yield return new WaitForSeconds(2.5f);
            m_Object.text = "Whoa";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "And every year. Our family blessings grow.";
            yield return new WaitForSeconds(2.5f);
            m_Object.text = "There's just a lot. You simply got to know so.";
            yield return new WaitForSeconds(3.2f);
            m_Object.text = "Welcome to the family Madrigal.";
            yield return new WaitForSeconds(3.3f);
            //fine

            m_Object.text = "The home of the family Madrigal.";
            yield return new WaitForSeconds(2.5f);
            m_Object.text = "We're on our way";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "Where all the people are fantastical. ";
            yield return new WaitForSeconds(2.1f);
            m_Object.text = " And magical";
            yield return new WaitForSeconds(1.2f);
            m_Object.text = "I'm part of the family Madrigal.";
            yield return new WaitForSeconds(2.5f);
            m_Object.text = "- Oh, my gosh! It's them! - What are the Gifts ? ";
            yield return new WaitForSeconds(2.5f);
            m_Object.text = "- I can't remember all the Gifts! - But I don't know who is who.";
            yield return new WaitForSeconds(2.3f);
            m_Object.text = "All right, all right, relax!";
            yield return new WaitForSeconds(1.4f);
            m_Object.text = "- It is physically impossible to relax! - Tell us everything!";
            yield return new WaitForSeconds(3f);
            m_Object.text = "- What are your powers? - Just tell us what everyone can do!";
            yield return new WaitForSeconds(2.8f);
            m_Object.text = "And that's why coffee's for grown-ups.";
            yield return new WaitForSeconds(2.2f);
            //fine

            m_Object.text = "My tía Pepa. Her mood affects the weather.";
            yield return new WaitForSeconds(3.7f);
            m_Object.text = "When she's unhappy.";
            yield return new WaitForSeconds(1.4f);
            m_Object.text = "Well, the temperature gets weird.";
            yield return new WaitForSeconds(1.9f);
            m_Object.text = "My tío Bruno";
            yield return new WaitForSeconds(1.5f);
            m_Object.text = "We don't talk about Bruno!";
            yield return new WaitForSeconds(2f);
            m_Object.text = "They say he saw the future, one day he disappeared.";
            yield return new WaitForSeconds(3.6f);
            m_Object.text = "Oh! And that's my mom Julieta.";
            yield return new WaitForSeconds(2f);
            m_Object.text = "Here's her deal.";
            yield return new WaitForSeconds(1.3f);
            m_Object.text = "Whoa";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "The truth is she can heal you with a meal.";
            yield return new WaitForSeconds(2.4f);
            m_Object.text = "Whoa";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "Her recipes are remedies for real.";
            yield return new WaitForSeconds(2.6f);
            m_Object.text = "If you're impressed imagine how I feel.";
            yield return new WaitForSeconds(2.6f);
            m_Object.text = "Mom";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "Welcome to the family Madrigal. ";
            yield return new WaitForSeconds(2.9f);

            //fine

            m_Object.text = "The home of the family Madrigal.";
            yield return new WaitForSeconds(2.4f);
            m_Object.text = "Hey, coming through!";
            yield return new WaitForSeconds(1.4f);
            m_Object.text = "I know it sounds a bit fantastical.";
            yield return new WaitForSeconds(2f);
            m_Object.text = "And magical";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "But I'm part of The family Madrigal ";
            yield return new WaitForSeconds(3.3f);
            m_Object.text = "Two guys fell in love.";
            yield return new WaitForSeconds(1.2f);
            m_Object.text = "With family Madrigal.";
            yield return new WaitForSeconds(2.2f);
            m_Object.text = "And now they're part of ";
            yield return new WaitForSeconds(1.2f);
            m_Object.text = "The family Madrigal";
            yield return new WaitForSeconds(2f);
            m_Object.text = "See, yeah, Tío Félix married Pepa.";
            yield return new WaitForSeconds(1.7f);
            m_Object.text = "And my dad married Julieta.";
            yield return new WaitForSeconds(1.5f);
            m_Object.text = "That's how Abuela became.";
            yield return new WaitForSeconds(1.3f);
            m_Object.text = "Abuela Madrigal";
            yield return new WaitForSeconds(1.8f);
            m_Object.text = "Let's go!";
            yield return new WaitForSeconds(1.3f);
            m_Object.text = " We swear to always help those around us.";
            yield return new WaitForSeconds(2.5f);
            //fine

            m_Object.text = "And earn the miracle that somehow found us.";
            yield return new WaitForSeconds(3.3f);
            m_Object.text = "The town keeps growing. The world keeps turning.";
            yield return new WaitForSeconds(2.9f);
            m_Object.text = "But work and dedication will keep the miracle burning.";
            yield return new WaitForSeconds(3.6f);
            m_Object.text = "And each new generation must keep the miracle burning";
            yield return new WaitForSeconds(4.3f);
            m_Object.text = "Wait, who's the sister and who's the cousin?";
            yield return new WaitForSeconds(1.9f);
            m_Object.text = "There are so many people!";
            yield return new WaitForSeconds(1.3f);
            m_Object.text = "How do you keep them all straight?";
            yield return new WaitForSeconds(1.2f);
            m_Object.text = "Okay, okay, okay. ";
            yield return new WaitForSeconds(1.8f);
            m_Object.text = "So many kids in our house so, let's turn the sound up.";
            yield return new WaitForSeconds(3.3f);
            m_Object.text = "You know why? I think it's time for a Grandkid Round - up!";
            yield return new WaitForSeconds(3.5f);
            m_Object.text = "Grandkid Round-up";
            yield return new WaitForSeconds(1.7f);
            m_Object.text = "Cousin Dolores can hear a pin drop";
            yield return new WaitForSeconds(3.2f);
            m_Object.text = "Camilo shapeshifts Antonio gets his Gift today.";
            yield return new WaitForSeconds(3.6f);
            m_Object.text = "My older sisters";
            yield return new WaitForSeconds(1.7f);
            m_Object.text = "Isabela and Luisa";
            yield return new WaitForSeconds(1.8f);
            //fine

            m_Object.text = "One strong, one graceful, perfect in every way.";
            yield return new WaitForSeconds(3.3f);
            m_Object.text = "Isabela";
            yield return new WaitForSeconds(1.5f);
            m_Object.text = "Grows a flower and the town goes wild.";
            yield return new WaitForSeconds(2f);
            m_Object.text = "Isabela";
            yield return new WaitForSeconds(1.2f);
            m_Object.text = "She's the perfect golden child.";
            yield return new WaitForSeconds(2.4f);
            m_Object.text = "Luisa, Luisa";
            yield return new WaitForSeconds(1.4f);
            m_Object.text = "And Luisa's super strong.";
            yield return new WaitForSeconds(1.9f);
            m_Object.text = "The beauty and the brawn. Do no wrong. ";
            yield return new WaitForSeconds(2.4f);
            m_Object.text = "- Let's get ready! - Coming";
            yield return new WaitForSeconds(2f);
            m_Object.text = "That's life in the family Madrigal.";
            yield return new WaitForSeconds(1.8f);
            m_Object.text = "Whoa";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "Now you know the family Madrigal.";
            yield return new WaitForSeconds(2.6f);
            m_Object.text = "Whoa";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = " Where all the people are fantastical.";
            yield return new WaitForSeconds(2f);
            m_Object.text = "And magical";
            yield return new WaitForSeconds(1.3f);
            //fine

            m_Object.text = "That's who we are in the family Madrigal.";
            yield return new WaitForSeconds(2.4f);
            m_Object.text = "Adiós";
            yield return new WaitForSeconds(1.9f);
            m_Object.text = "But what's your Gift?";
            yield return new WaitForSeconds(4.5f);
            m_Object.text = "Well, I gotta go the life of a Madrigal";
            yield return new WaitForSeconds(2.2f);
            m_Object.text = "Whoa";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "But now you all know the family Madrigal.";
            yield return new WaitForSeconds(2.5f);
            m_Object.text = "Whoa";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "I never meant this to get autobiographical";
            yield return new WaitForSeconds(2.9f);
            m_Object.text = "It was just to review the family Madrigal.  ";
            yield return new WaitForSeconds(2f);
            m_Object.text = "Let's go";
            yield return new WaitForSeconds(1f);
            m_Object.text = "But what about Mirabel?/It starts with Abuela.";
            yield return new WaitForSeconds(1.6f);
            m_Object.text = "And then Tía Pepa. She handles the weather.";
            yield return new WaitForSeconds(1.3f);
            m_Object.text = "But what about Mirabel?";
            yield return new WaitForSeconds(1.2f);
            m_Object.text = "My mom Julieta can make you feel better.";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "With just one arepa.";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "But what about Mirabel?/ My dad Agustín";
            yield return new WaitForSeconds(1.2f);

            //fine

            m_Object.text = "Well he's accident-prone but he means well. ";
            yield return new WaitForSeconds(2f);
            m_Object.text = "But what about Mirabel?";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "Hey you said you wanna know what everyone does.";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "I got sisters and cousins and";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "Mirabel";
            yield return new WaitForSeconds(1.1f);
            m_Object.text = "My primo Camilo won't stop until he makes you smile today.";
            yield return new WaitForSeconds(3f);
            m_Object.text = "My cousin Dolores can hear this whole chorus a mile away.";
            yield return new WaitForSeconds(2.8f);
            m_Object.text = "Look. It's Mr. Mariano.";
            yield return new WaitForSeconds(1.4f);
            m_Object.text = "Hey you can marry my sister if you wanna. ";
            yield return new WaitForSeconds(1.3f);
            m_Object.text = "Between you and me. She's kind of a prima donna";
            yield return new WaitForSeconds(1.6f);
            m_Object.text = "Oh, I've said too much and thank you.";
            yield return new WaitForSeconds(1.3f);
            m_Object.text = "But I really gotta go.";
            yield return new WaitForSeconds(1.3f);
            m_Object.text = "My family's amazing.";
            yield return new WaitForSeconds(1.7f);
            m_Object.text = " And I'm in my family so.";
            yield return new WaitForSeconds(1.2f);
            m_Object.text = "Well.";
            yield return new WaitForSeconds(1f);
            m_Object.text = "Mirabel!";
            yield return new WaitForSeconds(1.2f);


            m_Object.text = "What are you doing? ";
            yield return new WaitForSeconds(3.3f);
            m_Object.text = "They were just asking about the family and..";
            yield return new WaitForSeconds(2.1f);
            m_Object.text = "She was about to tell us about her super awesome Gift!";
            yield return new WaitForSeconds(3.9f);
            m_Object.text = "Oh, Mirabel didn't get one.";
        
        
    }
   public void StopSubtitle()
    {

        StopCoroutine("TheSequence");
    }
    public void StartSubtitle()
    {
        StartCoroutine("TheSequence");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
