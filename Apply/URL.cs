using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seek.Apply
{
    public class URL
    {
        //Save Jobs Applied For
        public bool SaveJobs { get; set; }

        //Id For Confirmation of Application Sent
        public string ApplicationSent = "applicationSent";

        public class Home
        {
            readonly string URL = "https://www.seek.com.au/";

            //Search
            public string KeyWords { get; set; }
            public string Classification { get; set; }
            public string Where { get; set; }

            //Job Description
            public string WorkTypes { get; set; }
            public string BaseWage { get; set; }
            public string TopWage { get; set; }
            public string ListingTime { get; set; }

            //Button
            public string SeekButton { get; set; }


        }

        public class SignIn
        {
            readonly string URL = "https://www.seek.com.au/sign-in";

            public string Email { get; set; }
            public string Password { get; set; }
            public bool StaySignedIn { get; set; }
            public string SignOnButton { get; set; }

        }

        public class JobPage
        {
            readonly string URL = "https://www.seek.com.au/jobs";

            List<Jobs> JobList { get; set; }

            public class Jobs
            {
                public string JobId { get; set; }
                public string SearchRequestToken { get; set; }
                public string AdType { get; set; }

                public string SearchLink { get; set; }
            }
        }

        public class ApplyForJob
        {
            public string URL = "https://www.seek.com.au/job/";

            //Further Experience Here.

            //Include Upload, Write and Do not Include.
            public string CoverLetter { get; set; }

            //Select Default, Upload or Do not Include.
            public string Resume { get; set; }


            //Further Questions from Employer Here.

            public string SubmitApplicationButton { get; set; }
        }

       


        public class Logout
        {
            readonly string URL = "https://www.seek.com.au/login/LogoutWithReturnUrl";
        }


        
        
        
        

        //public string MyProperty { get; set; }
        //public string MyProperty { get; set; }
        //public string MyProperty { get; set; }
        //public string MyProperty { get; set; }

    }
}
