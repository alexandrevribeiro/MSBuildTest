using System;
using Microsoft.Build.Utilities;
using Microsoft.Build.Framework;

namespace MSBuildTasks
{
    public class CheckIntegrityTask : Task
    {

        [Required]
        public bool ShowError { get; set; }

        [Output]
        public string SuccessMessage { get; set; }

        // Reference: http://thomasardal.com/msbuild-tutorial/ 
        public override bool Execute()
        {
            //throw new InvalidOperationException();
            if (ShowError)
            {
                Log.LogError("An error has occurred!!!");
                return false;
            }

            SuccessMessage = "Integrity check successufuly made!";
            return true;
        }
    }
}
