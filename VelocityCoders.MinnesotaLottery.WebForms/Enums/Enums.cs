namespace VelocityCoders.FitnessSchedule.WebForms
{
    public enum InstructorNavigation
    {
       
        /// <summary>
        /// Default to none value
        /// </summary>
        
        None,
       
        /// <summary>
        /// Page contains a list of Instructors
       /// </summary>
        InstructorList,
       
        /// <summary>
        /// Page contains basic Instructor info
        /// </summary>

        InstructorForm,
       
        /// <summary>
        /// Page contains Instructor Contract info
        /// </summary>

        ContactInfo,
       
        /// <summary>
        /// Page contains association between Instructor and Fitness Class
        /// </summary>

        FitnessClass,
       
        /// <summary>
        /// Page contains association between Location and Instructor
        /// </summary>

        Locations
    }
}