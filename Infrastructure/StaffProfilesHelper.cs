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
                OrderIndex = 1,
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
                OrderIndex = 4,
                Name = "Yelena Kilgore",
                Location = Location.Alexandria,
                Title = "Licensed Clinical Social Worker",
                ImagePath = "yelena.jpg",
                Bio = $"<p>Yelena contracts with HMT to provide counseling services at the Alexandria location. " +
                "She is a Licensed Clinical Social Worker (LCSW) specializing in " +
                "providing evidenced-based treatment to clients of all ages, facing a variety of challenges and issues " +
                "ranging from depression, anxiety, low self-esteem/poor self-image, relationship difficulties, to life " +
                "transitions of all types. She has spent a considerable portion of her career working in an acute psychiatric" +
                "hospital helping clients overcome mood disorders such as bipolar, suicidal ideation, depression, and anxiety. " +
                "During her time at the hospital, she has had the privilege of witnessing dramatic transformations of people " +
                "overcoming painful emotional distress and difficult life circumstances.</p>" +
                "<p>In her private clinical practice, she blends cognitive behavioral therapy (CBT) " +
                "and other evidence-based practices with an interpersonal process. She believes that " +
                "the key to effective treatment begins with the quality of the relationship and connection between a therapist and client, " +
                "as well as an inherent interest in understanding what drives our thoughts, emotions, and behaviors. Ms. Kilgore uses her " +
                "natural ability to empathize and offer unconditional positive regard with an interactive and warm therapeutic style to help" +
                "guide her clients towards building self-awareness, and ultimately, in realizing their own worth and abilities. She communicates " +
                "in an authentic and lively manner, and utilizes humor when appropriate. She works alongside her clients to help them navigate " +
                "life stressors and challenges while making you feel comfortable and understood. She challenges her clients appropriately by offering" +
                "a different perspective and new way of thinking. She is a guiding light.</p>" +
                "<p>Ms. Kilgore completed her master’s degree in Social Work at the University of Maryland and her undergraduate degree at the University " +
                "of Georgia. Her clinical internships included community mental health and extensive psychotherapy training at Catholic University " +
                "Counseling Center. Yelena was born in Uzbekistan and is fluent in Russian.</p>"
            });


            profiles.Add(new StaffProfile()
            {
                OrderIndex = 10,
                Name = "Rebecca Needy",
                Location = Location.Fredericksburg,
                Title = "Licensed Professional Counselor",
                ImagePath = "rebecca_needy.jpg",
                Bio = $"<p>Rebecca Needy contracts with HMT to provide counseling services at the Fredericksburg location." +
                "Rebecca completed her undergraduate coursework at Virginia Commonwealth University and in 2000 graduated with a Bachelor’s of Science concentration Therapeutic Recreation. She completed her graduate coursework at Virginia Tech and graduated in 2003 with her masters in Counselor Education with a focus in Community Counseling. Rebecca has 10 years of counseling experience that includes working with at risk youth in the community and in school settings. Rebecca also has practice utilizing Family Systems approach when working with families to improve familial relationships. Rebecca enjoys working with children and adolescents using aspects of play as well as art therapy. She also enjoys helping adults experiencing mood disorders and overwhelming anxiety take steps toward their individual wellness and utilize mindfulness as a therapeutic technique. Rebecca enjoys working with adults, adolescents and children individually as well as in a group setting, utilizing Cognitive Behavioral Therapy, Solution Focused and Reality Therapy. Rebecca provides a caring, empathetic, positive environment where individuals feel comfortable opening up and reflect about issues. The most important aspect of therapy to Rebecca is the therapeutic relationship.</p>"
            });

            profiles.Add(new StaffProfile()
            {
                OrderIndex = 7,
                Name = "Barbara Darby",
                Location = Location.Fredericksburg,
                Title = "Licensed Professional Counselor",
                ImagePath = "barbara_darby.jpg",
                Bio = $"<p>Barbara Darby contracts with HMT to provide counseling services at the Fredericksburg location. Barbara is a Virginia Licensed Professional Counselor with the Virginia Board of Counseling having earned her Master of Science in Mental Health Counseling from Nova Southeastern University. Her experience includes working with children, adolescents, adults, families and groups in community-based as well as inpatient and outpatient treatment settings. Her work, prior to entering private practice, focused on serving children/ adolescents and their families, and adults through the military health system by providing addiction and trauma focused services.</p>" +
                $"<p>She provides her clients with that warm, nonjudgmental environment, a safe place to explore the issues that may be preventing you from living the life you want. She is diverse in her orientation and offers a holistic, integrative approach to client-centered therapy, mindfulness based therapy, family systems work, and cognitive behavioral techniques. She has over 16 years of experience working with teens and adults who have struggled with anxiety, depression, addiction and trauma in individual, couples, and family therapy settings.</p>"
            });

            profiles.Add(new StaffProfile()
            {
                OrderIndex = 9,
                Name = "Shirley Bronston",
                Location = Location.Fredericksburg,
                Title = "Licensed Clinical Social Worker",
                ImagePath = "shirley_bronston.jpg",
                Bio = $"<p>Shirley Bronston contracts with HMT to provide counseling services at the Fredericksburg location. Shirley is a Licensed Clinical Social Worker. She is licensed by the Virginia Department of Health Professions. She is a seasoned social worker and has a variety of experience in the field of mental health working with a variety of individuals and their families. She also has over 20 years of experience working in community mental health agencies and private practices providing individual therapy, couples therapy, family therapy, parent education, and consultation services. While in the US Virgin Islands, she implemented quality medical care to individuals and their families. Shirley aspires for excellence, which is reflected in her Birth State's motto, 'Ad aspera per aspera', (to the stars through difficulties).</p>"
            });

            profiles.Add(new StaffProfile()
            {
                OrderIndex = 8,
                Name = "Karin Weber",
                Location = Location.Fredericksburg,
                Title = "Licensed Clinical Social Worker",
                ImagePath = "karin_weber.jpg",
                Bio = $"<p>Karin Weber contracts with HMT to provide counseling services at the Fredericksburg location. Karin is a Licensed Clinical Social Worker who is passionate about providing both individual and family therapy services that contribute to the healing and resilience of children, adolescents, adults, and their families. Karin has a warm and friendly demeanor which makes her a comfortable fit for individuals or families seeking support. Karin utilizes play therapy, which includes aspects of art, and music therapy, when working with children and adolescents. </p>" +
                $"<p>When working with adolescents and adults, she uses a strength-based perspective and incorporates Cognitive Behavioral approaches, inclusive of solution-focused, and goal-oriented therapy. Karin is also available to support parents in need of skills training or consultation.</p>" +
                $"<p>Karin received her Bachelors of Social Work degree from George Mason University in 2001, and her Masters of Social Work degree from Virginia Commonwealth University in 2006. Karin's post-graduate work was with a Community Services Board, in their Office of Mental Health, serving children, adolescents and their families. Karin has also instructed character education to preschoolers. She has related experience with adults dealing with traumatic experiences, chronic illness, substance use. She has co-facilitated a group for those surviving sexual assault.</p>" +
                $"<p>Karin understands the importance of developing resilience, as she brings life experience of adapting to a changing environment. She grew up in an Army family and has lived overseas.</p>"
            });

            profiles.Add(new StaffProfile()
            {
                OrderIndex = 11,
                Name = "Dianna Hart",
                Location = Location.Fredericksburg,
                Title = "Licensed Clinical Social Worker",
                ImagePath = "dianna_hart.jpg",
				Bio = $"<p>Dianna Hart contracts with HMT to provide neurofeedback and counseling services at the Fredericksburg location. Dianna Hart is a Licensed Clinical Social Worker (LCSW) with extensive experience helping children, teens, adults, and families in social service and mental health settings.  She is a compassionate and caring therapist committed to helping individuals fulfill their potential and break free from limitations created by stress and difficult life experiences or by developmental and physical challenges. Dianna earned her BA in Sociology with a concentration in social work from Old Dominion University and a Masters in Social Work degree from Virginia Commonwealth University.  She began her career working in child and family welfare services, including child protective services.   After graduate school Dianna worked with youth and their families at Prince William Community Services before joining a private practice in the Fredericksburg area. Dianna specializes in providing neurofeedback services, a cutting edge intervention she has been practicing since 2005.  She became Board Certified in Neurofeedback (BCN) through the Biofeedback Certification International Alliance in 2010.   She is also a member of the International Society for Neurofeedback and Research (www.isnr.org), whose mission is to promote excellence in clinical practice, educational applications, and research in applied neuroscience in order to better understand and enhance brain function. Neurofeedback is also called EEG biofeedback or neurotherapy.   It has been found to be a beneficial intervention for stress management and relaxation as well as many symptoms of ADHD, high functioning autism, PTSD (Post-Traumatic Stress Disorder),  OCD (Obsessive Compulsive Disorder), insomnia, anxiety, depression, traumatic brain injury, and many other conditions. Neurofeedback focuses on optimizing brain functioning by teaching the brain to better self-regulate and function more efficiently and effectively.   It has also been used to enhance cognitive and athletic performance by reducing anxiety, managing stress, and improving focus and attention. Dianna is also a skilled psychotherapist using a strengths-based approach that uses a person's self-determination and strengths -- and finds the personal resources and resiliency inherent in all of us.   She practices cognitive-behavior therapy (CBT), motivational interviewing techniques, solution-focused therapy, mindfulness, stress management and relaxation, and other specialized interventions appropriate for unique needs and circumstances. Research tells us that a good relationship between therapist and client is vital to successful outcomes no matter what therapeutic modality is used.  Dianna provides a warm, accepting alliance to those who seek her assistance and views the change process as a collaborative partnership.   She values each individual she meets and honors his or her experiences and strengths.  She wants to be a partner on your journey of self-discovery and recovery.</p>"
            });

            profiles.Add(new StaffProfile()
            {
                OrderIndex = 6,
                Name = "Stephanie Calvert",
                Location = Location.Fredericksburg,
                Title = "Licensed Clinical Social Worker",
                ImagePath = "Stephanie_Calvert.jpg",
                Bio = "<p>Stephanie Calvert contracts with HMT to provide counseling services at the Fredericksburg location. Stephanie is a Licensed Clinical Social Worker and Registered Play Therapist. Her experiences within the field of social work have included private practice, residential, community-based and in-home care. Clinical service, education, research and collaborative partnership inform her lens as she deepens understanding for where social justice and mental health intersect. Her purpose and commitment is to offer hope and promise of fulfillment to children, adults, and families who are at risk of not receiving effective services essential to their well-being</p>" +
                $"<p>Stephanie uses a child and person-centered approach to remind herself of how much courage it takes to be vulnerable irrespective of age, culture, and or socioeconomic background. A play therapy context renews Stephanie’s appreciation for creative process and healing. Stephanie is of the belief that the power for true Self-discovery is within everyone.</p>"
            });

            profiles.Add(new StaffProfile()
            {
                OrderIndex = 5,
                Name = "Cara Root",
                Location = Location.Woodbridge,
                Title = "Licensed Clinical Social Worker",
                ImagePath = "cara_root.jpg",
                Bio = $"<p>Cara Root contracts with HMT to provide counseling services at the Fredericksburg location. Cara Root is a Licensed Clinical Social Worker. She completed her Bachelor of Arts degrees in Sociology and Religious Studies at the College of William and Mary in 2005, and her Master of Science in Social Work degree from the University of Texas at Austin in 2007. She has experience with a wide variety of clients, including children, teenagers, adults, and families, and utilizes various therapy models such as child-centered and directed play therapy, cognitive behavioral therapy (CBT), solution-focused, and motivational interviewing. Cara's background includes work with children and families involved in the juvenile justice system, adults dealing with chronic illness and grief/loss, victims of sexual abuse and domestic violence, and clients experiencing depression/mood disorders, anxiety, ADHD, and PTSD. Cara offers Christian counseling for those interested in incorporating their faith into their treatment, and has been providing outpatient psychotherapy since 2011. She believes each person has their own unique story and utilizes innate strengths to assist clients in navigating through life's challenges. Cara has an empathetic listening ear and allows clients a safe place to explore feelings and experiences.</p>"

            });

            profiles.Add(new StaffProfile()
            {
                OrderIndex = 2,
                Name = "Karen Sexton",
                Location = Location.Fredericksburg,
                Title = "Director of Operations",
                ImagePath = "karen_sexton.jpg",
                Bio = $"<p>Karen Sexton, the Director of Operations, is a seasoned office manager with over 20 years of experience providing customer service to others. Her experience includes banking, facilitating title loans, and office management. She has brought positive change to Healthy Minds Therapy by advocating for patients and staff while ensuring financial success.</p>" +
                      $"<p>She is humble, efficient and does everything with a smile! Karen feels connected to her community as she has been a resident of Spotsylvania County for almost 30 years.</p>" +
                      $"<p>In addition to her dedication to her work with Healthy Minds, Karen is heavily involved with her church and family. Being a grandmother, mother and wife to her high school sweetheart is her true passion.</p>"
            });

            profiles.Add(new StaffProfile()
            {
                OrderIndex = 3,
                Name = "Becky Schneider",
                Location = Location.Fredericksburg,
                Title = "Director of First Impressions",
                ImagePath = "becky_scheider.jpg",
                Bio = $"<p>Becky Schneider, the Director of First Impressions, excels with this role beautifully. As the Director of First Impressions, she is responsible for making your experience with Healthy Minds Therapy as pleasant as can be! She enjoys interacting with the patients and works to ensure every patient feels welcomed.</p>" +
                    $"<p>Becky is energetic, efficient, creative, and memorable. She works to ensure your experience with Healthy Minds Therapy is meaningful as well! She is detail-oriented which helps to enhance the patient experience from your first phone call to your last session.</p>" +
                    $"<p>Becky graduated from Longwood University in 2017 with a degree in Communication Sciences and Disorders with a Minor in Special Education and a concentration Neurology. Born and raised in Orange County, Becky is a proud Virginian.</p>"
            });

            profiles.Add(new StaffProfile()
            {
                OrderIndex = 12,
                Name = "Alison Whitehouse",
                Location = Location.Woodbridge,
                Title = "Resident in Counseling",
                ImagePath = "allison_whitehouse.jpg",
                Bio = "<p>Alison is a resident in counseling providing counseling services at both the Woodbridge and Alexandria locations." +
                "Alison is a National Certified Counselor, and a recent graduate from William & Mary with a M.Ed. in Marriage & Family Counseling, following a B.S. in Psychology from William & Mary. Alison has completed rigorous internships working with individuals, couples, and families. Her goal in therapy is build trust and rapport so that her clients feel safe, comfortable, and heard throughout the therapeutic process. Alison is warm and bubbly, with the ability to match her clients in a way that creates a strong therapeutic relationship. As a young counselor, Alison works especially well with adolescent girls and adults." +
                "As a clinician, Alison’s theoretical approach is grounded in Cognitive Behavioral Therapy (CBT), Mindfulness, and Solution-Focused Therapy with postmodern and multi-cultural considerations. As a Marriage & Family Therapist, Alison uses Structural Family Therapy (SFT) and Narrative Family Therapy to assist you and your family in enhancing emotional communication, developing healthy roles, and creating a functioning family and/or couple dynamic. Her goal is to create a safe environment where the family or couple can explore conflicts and address unproductive interaction patterns. With this systems-approach, therapy can create long-lasting positive change. " +
                "As a Resident in Counseling, Alison is currently involved in the state licensure process for the Commonwealth of Virginia. She is actively pursuing a License in Professional Counseling (LPC), as well as a License in Marriage & Family Therapy (LMFT). As a new clinician, Alison provides a fresh and up-to-date approach to therapy, valuing the therapeutic relationship as central to achieve goals toward wellness. Alison has particular interest in working with adolescents, couples/families, as well as military service members and their families, due to her own experience growing up in a Marine Corps family. Alison also provides a safe space for all LGBTQ individuals." +
                "</p>"
            });

            return profiles;
        }
    }
}