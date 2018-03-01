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
                ImagePath = "aly.jpg",
                Bio = $"<p>Alycia Burant is a Licensed Professional Counselor with over nine years experience providing direct patient care to adults, adolescents, children, and families. She is also your average every-day girl who has dealt with her own array of challenges. By changing her thoughts and developing positive, healthy coping skills she has created a positive healthy mind, body and soul.</p>" +
                $"<p>Alycia was born with a strong empathetic nature that compliments her powerful intuition well. She provides a safe, supportive, encouraging environment by creating a solid foundation for personal healing and development. She works to create a relationship with you to promote success and empowerment. She recognizes you are the expert on your life and takes a collaborative approach to achieve identified goals. Alycia uses a strength-based approach, building on your positive qualities. She recognizes everyone measures success differently and tailors treatment to best meet your needs.</p>" +
                $"<p>Are you struggling with every day anxieties that are starting to impact your relationships, job, or home life? Do you feel so depressed you have lost motivation to do things you used to enjoy? If you can relate to any of this, then Alycia is the right person for you. She will help you become the person you want to be.</p>" +
                $"<p>Alycia received her Bachelor of Science in Psychology from Virginia Tech in 2006. She earned her Master of Arts in Community Counseling from the American Psychological Association (APA) accredited Argosy University School of Professional Psychology Northern Virginia in 2009. She completed her Post Master’s Certification in School Counseling at University of South Florida in 2014. During her journey as a therapist thus far, she has had the pleasure of working with clients in a variety of settings to include in-home, psychiatric hospitals, mental health clinics, and outpatient/private practice settings.</p>"
            });

            profiles.Add(new StaffProfile()
            {
                Name = "Yelena Kilgore",
                Location = Location.Alexandria,
                Title = "Licensed Clinical Social Worker",
                ImagePath = "yelena.jpg",
                Bio = $"<p>Yelena Kilgore, Licensed Clinical Social Worker (LCSW) is a psychotherapist specializing in " +
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
                $"guide her clients towards building self-awareness, and ultimately, in realizing their own worth and abilities. She communicates " +
                $"in an authentic and lively manner, and utilizes humor when appropriate. She works alongside her clients to help them navigate " +
                $"life stressors and challenges while making you feel comfortable and understood. She challenges her clients appropriately by offering" +
                $"a different perspective and new way of thinking. She is a guiding light.</p>" +
                $"<p>Ms. Kilgore completed her master’s degree in Social Work at the University of Maryland and her undergraduate degree at the University " +
                $"of Georgia. Her clinical internships included community mental health and extensive psychotherapy training at Catholic University " +
                $"Counseling Center. Yelena was born in Uzbekistan and is fluent in Russian.</p>"
            });


            profiles.Add(new StaffProfile()
            {
                Name = "Rebecca Needy",
                Location = Location.Fredericksburg,
                Title = "Licensed Professional Counselor",
                ImagePath = "rebecca_needy.jpg",
                Bio = $"<p>Rebecca Needy completed her undergraduate coursework at Virginia Commonwealth University and in 2000 graduated with a Bachelor’s of Science concentration Therapeutic Recreation. She completed her graduate coursework at Virginia Tech and graduated in 2003 with her masters in Counselor Education with a focus in Community Counseling. Rebecca has 10 years of counseling experience that includes working with at risk youth in the community and in school settings. Rebecca also has practice utilizing Family Systems approach when working with families to improve familial relationships. Rebecca enjoys working with children and adolescents using aspects of play as well as art therapy. She also enjoys helping adults experiencing mood disorders and overwhelming anxiety take steps toward their individual wellness and utilize mindfulness as a therapeutic technique. Rebecca enjoys working with adults, adolescents and children individually as well as in a group setting, utilizing Cognitive Behavioral Therapy, Solution Focused and Reality Therapy. Rebecca provides a caring, empathetic, positive environment where individuals feel comfortable opening up and reflect about issues. The most important aspect of therapy to Rebecca is the therapeutic relationship.</p>"
            });

            profiles.Add(new StaffProfile()
            {
                Name = "Barbara Darby",
                Location = Location.Fredericksburg,
                Title = "Licensed Professional Counselor",
                ImagePath = "barbara_darby.jpg",
                Bio = $"<p>Barbara is a Virginia Licensed Professional Counselor with the Virginia Board of Counseling having earned her Master of Science in Mental Health Counseling from Nova Southeastern University. Her experience includes working with children, adolescents, adults, families and groups in community-based as well as inpatient and outpatient treatment settings. Her work, prior to entering private practice, focused on serving children/ adolescents and their families, and adults through the military health system by providing addiction and trauma focused services.</p>" +
                $"<p>She provides her clients with that warm, nonjudgmental environment, a safe place to explore the issues that may be preventing you from living the life you want. She is diverse in her orientation and offers a holistic, integrative approach to client-centered therapy, mindfulness based therapy, family systems work, and cognitive behavioral techniques. She has over 16 years of experience working with teens and adults who have struggled with anxiety, depression, addiction and trauma in individual, couples, and family therapy settings.</p>"
            });

            profiles.Add(new StaffProfile()
            {
                Name = "Shirley Bronston",
                Location = Location.Fredericksburg,
                Title = "Licensed Clinical Social Worker",
                ImagePath = "shirley_bronston.jpg",
                Bio = $"<p>Shirley is a Licensed Clinical Social Worker. She is licensed by the Virginia Department of Health Professions. She is a seasoned social worker and has a variety of experience in the field of mental health working with a variety of individuals and their families. She also has over 20 years of experience working in community mental health agencies and private practices providing individual therapy, couples therapy, family therapy, parent education, and consultation services. While in the US Virgin Islands, she implemented quality medical care to individuals and their families. Shirley aspires for excellence, which is reflected in her Birth State's motto, 'Ad aspera per aspera', (to the stars through difficulties).</p>"
            });

            profiles.Add(new StaffProfile()
            {
                Name = "Karin Weber",
                Location = Location.Fredericksburg,
                Title = "Licensed Clinical Social Worker",
                ImagePath = "karin_weber.jpg",
                Bio = $"<p>Karin Weber is a Licensed Clinical Social Worker who is passionate about providing both individual and family therapy services that contribute to the healing and resilience of children, adolescents, adults, and their families. Karin has a warm and friendly demeanor which makes her a comfortable fit for individuals or families seeking support. Karin utilizes aspects of play, art, and music as well as timeline therapy when working with children. When working with adolescents and adults, she uses a strength based perspective and incorporates Cognitive Behavioral approaches, inclusive of solution-focused, and goal-oriented therapy. Karin is also a great support to parents in need of skills training or consultation.</p>" +
                $"<p>Karin received her Bachelors of Social Work degree from GeorgeMason University in 2001, and her Masters of Social Work degree from VirginiaCommonwealth University in 2006. Karin's post-graduate work was with a Community Services Board, in their Office of Mental Health, serving children, adolescents and their families. Karin has also instructed character education to preschoolers. She has related experience with adults dealing with chronic illness and substance use as well as those surviving sexual assault.</p>" +
                $"<p>Karin understands the importance of developing resilience as she brings life experience of adapting to a changing environment. She grew up in an Army family and has lived overseas.</p>"
            });

            profiles.Add(new StaffProfile()
            {
                Name = "Dianna Hart",
                Location = Location.Fredericksburg,
                Title = "Licensed Clinical Social Worker",
                ImagePath = "dianna_hart.jpg",
                Bio = $"<p>Dianna Hart is a Licensed Clinical Social Worker. Dianna is an experienced psychotherapist and family therapist working with all age groups. Her therapeutic approach includes cognitive-behavioral therapy, solution-focused therapy, motivational interviewing techniques, mindfulness practices, and stress reduction and relaxation strategies. When appropriate she integrates therapeutic interventions with neurotherapy to assist in enhancing an individual’s overall progress and recovery. Dianna is a BCN. Dianna works with children, adolescents, and adults providing neurotherapy. Utilizing neurotherapy to help patients and their families, she has experience working with a variety of concerns, including ADHD symptoms, high-functioning autism, insomnia, anxiety, depression, bipolar disorder, stress reduction, brain injury, peak performance, and other conditions.</p>" +
                $"<p>Dianna received her Bachelor of Arts in Sociology from Old Dominion University. She received from Virginia Commonwealth University. She has worked in child welfare and family services for 27 years before moving to the behavioral health field. She has 14 years of experience in behavioral health, working with children, youth, and their families.</p>"
            });

            profiles.Add(new StaffProfile()
            {
                Name = "Stephanie Calbert",
                Location = Location.Fredericksburg,
                Title = "Licensed Clinical Social Worker",
                ImagePath = "Stephanie_Calvert.jpg",
                Bio = "<p>Stephanie is a Licensed Clinical Social Worker and Registered Play Therapist. Her experiences within the field of social work have included private practice, residential, community-based and in-home care. Clinical service, education, research and collaborative partnership inform her lens as she deepens understanding for where social justice and mental health intersect. Her purpose and commitment is to offer hope and promise of fulfillment to children, adults, and families who are at risk of not receiving effective services essential to their well-being</p>" +
                $"<p>Stephanie uses a child and person-centered approach to remind herself of how much courage it takes to be vulnerable irrespective of age, culture, and or socioeconomic background. A play therapy context renews Stephanie’s appreciation for creative process and healing. Stephanie is of the belief that the power for true Self-discovery is within everyone.</p>"
            });

            profiles.Add(new StaffProfile()
            {
                Name = "Cara Root",
                Location = Location.Woodbridge,
                Title = "Licensed Clinical Social Worker",
                ImagePath = "cara_root.jpg",
                Bio = $"<p>Cara Root is a Licensed Clinical Social Worker. She completed her Bachelor of Arts degrees in Sociology and Religious Studies at the College of William and Mary in 2005, and her Master of Science in Social Work degree from the University of Texas at Austin in 2007. She has experience with a wide variety of clients, including children, teenagers, adults, and families, and utilizes various therapy models such as child-centered and directed play therapy, cognitive behavioral therapy (CBT), solution-focused, and motivational interviewing. Cara's background includes work with children and families involved in the juvenile justice system, adults dealing with chronic illness and grief/loss, victims of sexual abuse and domestic violence, and clients experiencing depression/mood disorders, anxiety, ADHD, and PTSD. Cara offers Christian counseling for those interested in incorporating their faith into their treatment, and has been providing outpatient psychotherapy since 2011. She believes each person has their own unique story and utilizes innate strengths to assist clients in navigating through life's challenges. Cara has an empathetic listening ear and allows clients a safe place to explore feelings and experiences.</p>"

            });

            profiles.Add(new StaffProfile()
            {
                Name = "Kimberly Milam",
                Location = Location.Woodbridge,
                Title = "Licensed Professional Counselor",
                ImagePath = "Kimberly_Milam.jpg",
                Bio = $"<p>Kim Milam is a Licensed Professional Counselor. Kim utilizes evidence based interventions to help her clients reach their true potential and therapeutic goals. Kim is skilled in using cognitive-behavioral therapy, solution-focused therapy, motivational interviewing, EMDR, neurotherapy, articular acupuncture, emotional freedom techniques, trauma informed care, mindfulness practices, and stress reduction and relaxation strategies. When appropriate she integrates therapeutic interventions with neurotherapy.</p>" +
                $"<p>Neurotherapy can be used to help clients with ADHD, high-functioning autism, insomnia, anxiety, depression, bipolar disorder, stress reduction, brain injury, peak performance, and other conditions.</p>" +
                $"<p>Kim received her graduate degree in Counseling from Argosy University in 2012. Kim served 21 years in the United States Army, where she deployed to Afghanistan and worked with victims of sexual assault. She has worked with military members and their families, children, adolescents, couples, and families over the last six years in both intensive in home and outpatient settings</p>"
            });


            return profiles;
        }
    }
}