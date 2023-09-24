using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using start_project;
using start_project.ApplicationDbContext;
using start_project.Dtos;
using start_project.models;
using start_project.Repositories;


public class Program
{
    public static async Task Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((services) =>
            {
                // Register the Service
                services.AddScoped<IProgramService, ProgramSerivce>();
                services.AddScoped<IFormService, FormService>();
                services.AddScoped<IWorkFlowService, WorkFlowService>();
                // Register the DbContext class with a scoped lifetime.
                services.AddScoped<Applicationdbcontext>();
            })
            .Build();

        // Get the IProgramService service from the container.
        var programService = host.Services.GetService<IProgramService>();
        #region AddProgramDetails




        //var programDetailsDto = new ProgramDetailsDto()
        //{

        //    Title = "prog1",
        //    summary = "prog_sum",
        //    description = "prog_desc",
        //    benefits = "prog_benefit",
        //    criteria = "prog_critrtia",
        //    Close = new DateTime(),
        //    Open = new DateTime(),
        //    Duration = 6,
        //    Location = "XYZ",
        //    maxnumber = 5000,
        //    skills = new List<skills> { skills.Graphic_Design, skills.UI },
        //    qualifications = Qualification.HighSchool,
        //    types = ProgramTypes.Internship
        //};
        //var programdetails = new Programdetails
        //{
        //    benefits = programDetailsDto.benefits,
        //    Close = programDetailsDto.Close,
        //    criteria = programDetailsDto.criteria,
        //    description = programDetailsDto.description,
        //    Location = programDetailsDto.Location,
        //    maxnumber = programDetailsDto.maxnumber,
        //    skills = programDetailsDto.skills.Select(s => s.ToString()).ToList(),
        //    summary = programDetailsDto.summary,
        //    Title = programDetailsDto.Title,
        //    Open = programDetailsDto.Open,
        //    Duration = programDetailsDto.Duration,
        //    qualifications = programDetailsDto.qualifications.ToString(),
        //    types = programDetailsDto.types.ToString()
        //};
        //programService.AddProgramDetails(programdetails);


        #endregion

        #region GetProgramDetails
        //var programdetails = programService.GetAllDetails();
        //foreach (var item in programdetails)
        //{
        //    Console.WriteLine("Title : " + item.Title);
        // foreach(var skill in item.skills) {

        //        Console.WriteLine(skill);
        //    }

        //}
        #endregion

        #region UpdateDetails
        //var existprogramdetails = programService.GetProgramDetails("fcead599-ed67-41ba-a21b-1c359c9257a9");
        //var programDetailsDto = new ProgramDetailsDto()
        //{

        //    Title = "prog1_updated",
        //    summary = "prog_sum_updated",
        //    description = "prog_desc",
        //    benefits = "prog_benefit",
        //    criteria = "prog_critrtia",
        //    Close = new DateTime(),
        //    Open = new DateTime(),
        //    Duration = 6,
        //    Location = "XYZ",
        //    maxnumber = 5000,
        //    skills = new List<skills> { skills.UX, skills.SocialMedia },
        //    qualifications = Qualification.HighSchool,
        //    types = ProgramTypes.Internship
        //};
        //existprogramdetails.benefits = programDetailsDto.benefits;
        //existprogramdetails.skills = programDetailsDto.skills.Select(s => s.ToString()).ToList();
        //existprogramdetails.Close = programDetailsDto.Close;
        //existprogramdetails.Title = programDetailsDto.Title;
        //existprogramdetails.Open = programDetailsDto.Open;
        //existprogramdetails.summary = programDetailsDto.summary;
        //existprogramdetails.description = programDetailsDto.description;
        //existprogramdetails.Duration = programDetailsDto.Duration;
        //existprogramdetails.criteria = programDetailsDto.criteria;
        //existprogramdetails.maxnumber = programDetailsDto.maxnumber;
        //existprogramdetails.Location = programDetailsDto.Location;
        //existprogramdetails.qualifications = programDetailsDto.qualifications.ToString();
        //existprogramdetails.types = programDetailsDto.types.ToString();
        //programService.UpdateProgramDetails(existprogramdetails);




        #endregion

        // Get the IFormService service from the container.
        var FormService = host.Services.GetService<IFormService>();
        #region Add Application Form
        //var formddto = new ApplicationFormDto
        //{
        //    Image = "fakeimapng",
        //    PersonalInformation = new PersonalInformation
        //    {
        //        Firstname = "omar12",
        //        Lastname = "Farouk1010",
        //        Birthdate = DateTime.Now,
        //        currentresidence = "Cairo1555",
        //        email = "Test@test.com",
        //        Gender = "male",
        //        IDnumber = 1234,
        //        nationality = "Egyption",
        //        phone = 0112212345,
        //        Question = new List<Question>() { new Question() { text = "What Your Age", Questiontype = Questiontype.number }, new Question() { text = "Tell Me About Your Self", Questiontype = Questiontype.shortanswer } }


        //    },
        //    Profile = new Profile
        //    {
        //        education = new Education
        //        {
        //            courseName = "BA History",
        //            Degree = "Bch",
        //            Location = "New Cairo",
        //            School = "Ain Shams",
        //            question = new List<Question>() { new Question() { text = "What is Your Dream", Questiontype = Questiontype.paragraph } },
        //            End = DateTime.Now,
        //            Start = DateTime.Now,

        //        },
        //        resume = "Link1",
        //        experince = new Experince
        //        {
        //            Start = DateTime.Now,
        //            End = DateTime.Now,
        //            Location = "New Cairo",
        //            Comapny = "XYZ",
        //            Title = "Full Stack Developer",
        //            question = new List<Question>() { new Question() { text = "What is Dtos", Questiontype = Questiontype.paragraph } }
        //        },


        //    },
        //    Question = new List<Question>() { new Question() { text = "What is the best movie for you", Questiontype = Questiontype.multiplechoice } }




        //};
        //var newform = new ApplicationForm
        //{
        //    Image = formddto.Image,
        //    PersonalInformation = new PersonalInformation
        //    {
        //        email = formddto.PersonalInformation.email,
        //        currentresidence = formddto.PersonalInformation.currentresidence,
        //        phone = formddto.PersonalInformation.phone,
        //        Firstname = formddto.PersonalInformation.Firstname,
        //        Lastname = formddto.PersonalInformation.Lastname,
        //        Gender = formddto.PersonalInformation.Gender,
        //        Birthdate = formddto.PersonalInformation.Birthdate,
        //        nationality = formddto.PersonalInformation.nationality,
        //        IDnumber = formddto.PersonalInformation.IDnumber,
        //        Question = formddto.PersonalInformation.Question.Select(x => new Question
        //        {
        //            text = x.text,
        //            Questiontype = x.Questiontype,
        //            QType = x.Questiontype.ToString(),

        //        }).ToList()
        //    },

        //    Profile = new Profile
        //    {

        //        education = new Education
        //        {
        //            courseName = formddto.Profile.education.courseName,
        //            Degree = formddto.Profile.education.Degree,
        //            End = formddto.Profile.education.End,
        //            Location = formddto.Profile.education.Location,
        //            School = formddto.Profile.education.School,
        //            Start = formddto.Profile.education.Start,
        //            question = formddto.Profile.education.question.Select(x => new Question
        //            {
        //                text = x.text,
        //                Questiontype = x.Questiontype,
        //                QType = x.Questiontype.ToString(),
        //            }).ToList()
        //        },
        //        experince = new Experince
        //        {
        //            Comapny = formddto.Profile.experince.Comapny,
        //            Location = formddto.Profile.experince.Location,
        //            End = formddto.Profile.experince.End,
        //            Start = formddto.Profile.experince.Start,
        //            Title = formddto.Profile.experince.Title,
        //            question = formddto.Profile.experince.question.Select(x => new Question
        //            {
        //                text = x.text,
        //                Questiontype = x.Questiontype,
        //                QType = x.Questiontype.ToString(),

        //            }).ToList()
        //        },
        //        resume = formddto.Profile.resume,
        //        question = formddto.Profile.question?.Select(x => new Question
        //        {
        //            text = x.text,
        //            Questiontype = x.Questiontype,
        //            QType = x.Questiontype.ToString()

        //        }).ToList()

        //    },
        //    ProgramdetailsID = "fcead599-ed67-41ba-a21b-1c359c9257a9",
        //    Question = formddto.Question.Select(x => new Question
        //    {
        //        text = x.text,
        //        Questiontype = x.Questiontype,
        //        QType = x.Questiontype.ToString(),
        //    }).ToList(),

        //};
        //FormService.AddForm(newform);
        #endregion

        #region Update Application Form
        //var existform = FormService.GetForm("d796928a-8ee9-4c1f-85b1-9b77e28ccf71");


        //var formddto = new ApplicationFormDto
        //{
        //    Image = "xxx",
        //    PersonalInformation = new PersonalInformation
        //    {
        //        Firstname = "omar",
        //        Lastname = "Farouk",
        //        Birthdate = DateTime.Now,
        //        currentresidence = "Cairo",
        //        email = "Test@test.com",
        //        Gender = "male",
        //        IDnumber = 1234,
        //        nationality = "Egyption",
        //        phone = 0112212345,
        //        Question = new List<Question>() { new Question() { text = "What Your Age", Questiontype = Questiontype.number }, new Question() { text = "Tell Me About Your Self", Questiontype = Questiontype.shortanswer } }


        //    },
        //    Profile = new Profile
        //    {
        //        education = new Education
        //        {
        //            courseName = "BA History",
        //            Degree = "Bch",
        //            Location = "New Cairo",
        //            School = "Ain Shams",
        //            question = new List<Question>() { new Question() { text = "What is Your Dream", Questiontype = Questiontype.paragraph } },
        //            End = DateTime.Now,
        //            Start = DateTime.Now,

        //        },
        //        resume = "Link1",
        //        experince = new Experince
        //        {
        //            Start = DateTime.Now,
        //            End = DateTime.Now,
        //            Location = "New Cairo",
        //            Comapny = "XYZ",
        //            Title = "Full Stack Developer",
        //            question = new List<Question>() { new Question() { text = "What is Dtos", Questiontype = Questiontype.paragraph } }

        //        },

        //    },
        //    Question = new List<Question>() { new Question() { text = "What is the best movie for you", Questiontype = Questiontype.multiplechoice } },




        //};
        //existform.Image = formddto.Image;
        //existform.PersonalInformation = formddto.PersonalInformation;
        //existform.Question = formddto.Question;
        //existform.Profile = formddto.Profile;
        //FormService.UpdateForm(existform);
        #endregion

        #region GET Application Form
        //var forms = FormService.GetForms();
        //foreach (var item in forms)

        //{
        //    Console.WriteLine(item.Image);


        //};

        #endregion

        // Get the IWorkFlowService service from the container.
        var WorkFlow = host.Services.GetService<IWorkFlowService>();
        #region Add WorkFlow
        //var workflowdto = new WorkFlowDto
        //{
        //    Name = "Round1",
        //    Stagetype = Stagetype.Video,

        //};
        //var newworkflow = new WorkFlow
        //{
        //    Name = workflowdto.Name,
        //    Stagetype = workflowdto.Stagetype,
        //    ProgramdetailsID = "fcead599-ed67-41ba-a21b-1c359c9257a9",

        //};
        //WorkFlow.Add(newworkflow);

        #endregion

        #region Update WorkFlow
        //var existworkflow = WorkFlow.GetWorkFlow("a09d84b1-3682-4cd1-b7e7-c2c057082f56");
        //var workflowdto = new WorkFlowDto
        //{
        //    Name = "Round50",
        //    Stagetype = Stagetype.Video,

        //};
        //existworkflow.Name = workflowdto.Name;
        //existworkflow.Stagetype = workflowdto.Stagetype;
        //WorkFlow.Update(existworkflow);

        #endregion

        #region Get WorkFlow
        //var workflow = WorkFlow.GetAllWorkFlow();
        //foreach (var item in workflow)
        //{
        //    Console.WriteLine(item.Name);

        //}
        #endregion

        //Get Preview Of Program 
        #region Get Preview OF Program Details
        //var programPreview = programService.GetProgramDetails("fcead599-ed67-41ba-a21b-1c359c9257a9");
        //Console.WriteLine(programPreview.Title);
        //Console.WriteLine(programPreview.summary);
        //Console.WriteLine(programPreview.description);
        //foreach (var item in programPreview.skills)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine(programPreview.benefits);
        //Console.WriteLine(programPreview.criteria);
        #endregion














    }
}

