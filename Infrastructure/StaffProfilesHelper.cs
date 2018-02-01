using System.Collections.Generic;
using HMTCoreVue.Models;

namespace HMTCoreVue.Infrastructure
{

    public class StaffProfilesHelper
    {

        public IList<StaffProfile> init()
        {
            var profiles = new List<StaffProfile>();
            profiles.Add(new StaffProfile()
            {
                Name = "Alycia Burant",
                Title = "Licensed Professional Counselor",
                Location = Location.Alexandria,
                SpecialJobDesignation = "Owner and Clinical Director",
                ImagePath = "../../images/aly.jpg",
                Bio = $"<p>Alyicia Burant is a Licensed " +
                      $"Professional Counselor with over seven years experience providing direct" +
                      $"patient care to adults, adolescents, children, and families. She is " +
                      $"also your average every day girl who has dealt with her own array of challenges " +
                      $"by changing her thoughts and developing positive, healthy coping skills.</p><p>" +
                      $"Alycia created a positive healthy mind, body and soul. She provides a safe, supportive, " +
                      $"encouraging environment by creating a solid foundation for personal healing " +
                      $"and development. Alycia works to create a relationship with you to promote " +
                      $"success and empowerment. She recognizes you are the expert on your life " +
                      $"and take a collaborative approach to achieve identified goals. Alycia uses " +
                      $"a strength-based approach, building on your positive qualities. She recognizes " +
                      $"everyone measures success differently and tailor treatment to best meet " +
                      $"your needs. Are you struggling with every day anxieties that are starting " +
                      $"to impact your relationships, job, or home life? Do you feel so depressed " +
                      $"you have lost motivation to do things you used to enjoy? Do you have " +
                      $"a teenager who seems distant but has hinted they would like someone to " +
                      $"talk to? If you can relate to any of this, then you’ve come to the right " +
                      $" place. Healthy Minds Therapy will help you become the person you want to be! " +
                      $"</p><p>Alycia received her Bachelor of Science in Psychology from Virginia Tech in 2006. She earned my Master of Arts in Community Counseling " +
                      $" from American Psychological Association (APA) accredited Argosy " +
                      $" University School of Professional Psychology Northern Virginia" +
                      $" in 2009. She completed my Post Master’s Certification in School " +
                      $" Counseling at University of South Florida in 2014. During her" +
                      $" journey as a therapist thus far, she has had the pleasure of working" +
                      $" with clients in a variety of settings to include in-home, psychiatric" +
                      $" hospitals, mental health clinics, and outpatient/private practice settings.</p>"
            });

            profiles.Add(new StaffProfile(){
                Name = "Yelana Boex", 
                Location = Location.Alexandria,
                Title = "Licensed Clinical Social Worker",
                ImagePath = "../../images/yelena.jpg",
                Bio = $"<p>Yelena Kilgore, Licensed Clinical Social Worker (LCSW) is a psychotherapist specializing in "+
                $" providing evidenced-based treatment to clients of all ages, facing a variety of challenges and issues " +
                $"ranging from depression, anxiety, low self-esteem/poor self-image, relationship difficulties, to life " + 
                $"transitions of all types. She has spent a considerable portion of her career working in an acute psychiatric" +
                $"hospital helping clients overcome mood disorders such as bipolar, suicidal ideation, depression, and anxiety. " +
                $"During her time at the hospital, she has had the privilege of witnessing dramatic transformations of people " +
                $"overcoming painful emotional distress and difficult life circumstances.</p>" +
                $"<p>In her private clinical practice, she blends cognitive behavioral therapy (CBT) " + 
                $"and other evidence-based practices with an interpersonal process. She believes that " +
                $"the key to effective treatment begins with the quality of the relationship and connection between a therapist and client, " +
                $"as well as an inherent interest in understanding what drives our thoughts, emotions, and behaviors. Ms. Kilgore uses her " +
                $"natural ability to empathize and offer unconditional positive regard with an interactive and warm therapeutic style to help" +
                $"guide her clients towards building self-awareness, and ultimately, in realizing their own worth and abilities. She communicates" +
                $"in an authentic and lively manner, and utilizes humor when appropriate. She works alongside her clients to help them navigate " + 
                $"life stressors and challenges while making you feel comfortable and understood. She challenges her clients appropriately by offering" +
                $"a different perspective and new way of thinking. She is a guiding light.</p>" +
                $"<p>Ms. Kilgore completed her master’s degree in Social Work at the University of Maryland and her undergraduate degree at the University " + 
                $"of Georgia. Her clinical internships included community mental health and extensive psychotherapy training at Catholic University " +
                $"Counseling Center. Yelena was born in Uzbekistan and is fluent in Russian.</p>"
            });

            profiles.Add(new StaffProfile() {
                Name = "Dr. Sarah Lyall, PsyD",
                Location = Location.Fredericksberg,
                Title = "Clinical Psychologist",
                ImagePath = "../../images/sarah_lyall.jpg",
                Bio = $"<p>Dr. Lyall is a licensed clinical psychologist in both Virginia and Alabama. She practices from a strengths based perspective, aiding her clients in identifying and utilizing the strengths that are already present within them to meet their goals and enhance their lives. Dr. Lyall provides a welcoming safe environment for all clients.</p>" + 
                $"<p>Dr. Lyall has experience working in a variety of mental health settings, including hospitals, integrated behavioral health/medical clinics, and behavioral health outpatient clinics. She also has experience utilizing Cognitive Behavioral Therapy (CBT), Solution Focused Brief Therapy (SFBT), Acceptance and Commitment Therapy (ACT), and various mindfulness techniques to help patients meet their goals.</p>" + 
                $"<p>A Virginia native, Dr. Lyall completed her undergraduate work in psychology at The University of Virginia’s College at Wise. She completed a Master’s Degree in Counseling and Human Development and later a Doctoral Degree in Counseling Psychology at Radford University.</p>" +
                $"<p>Dr. Lyall has experience in working with clients who suffer from a broad range of diagnoses, including but not limited to, mood disorders, trauma related disorders including PTSD, and adjustment disorders. Dr. Lyall has a special interest in working with clients who are suffering from chronic pain and has specialized training in helping patients learn coping strategies to help them reduce their use of potentially addictive pain medications.</p>"
            });

            return profiles;
        }

    }
}