using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

/*
    Course Folder     
*/

namespace Singleton.CourseFolder
{
    public enum DocumentType
    {
        Assignment, Quiz, Sessional, Final, Project
    }


    public class Owner
    {
        public string Faculty { get; set; }
    }
    public class CourseFolderContents
    {
        public string CoruseTitle { get; set; }
        //Document Type
        public DocumentType DocumentType { get; set; }
        //Title : Quiz 1
        public string Title { get; set; }

        //Date uploaded
        public DateTime DateCreated { get; set; }

        //File Path
        public string FileUrl { get; set; }
    }


}

