namespace StudentHelper.Core
{
    public class StudentHelper
    {
        private const int MATHS_EXTRA_LIMIT = 5;
        private const int NOT_QUALIFIED_BASE = 20;
        private const int QUALIFIED_BASE = 80;
        private enum QuizQualifyResult
        {
            YES,
            NO,
            MAYBE
        }

        /*  PROBLEM 3
* You and your Friend are planning to enter a Subject Quiz.
* However, there is a marks requirement that you should attain to qualify.
* 
* Return value can be YES, NO or MAYBE.
* 
* YES If either of you are very good at the subject(has 80 or more marks)
* However, there is an exception that if either of you is not good in the subject(20 or less marks), it is NO.
* In all other conditions, return MAYBE.
* 
* However, the definition for good and not good are 5 marks higher if the subject is Mathematics.
* 
* marks1 - your marks
* marks2 - your friends marks
*/
        public static string WillQualifyForQuiz(int marks1, int marks2, bool isMaths)
        {
            int extraLimit = isMaths ? MATHS_EXTRA_LIMIT : 0;
            int notQualifiedLimit = NOT_QUALIFIED_BASE + extraLimit;
            int qualifiedLimit = QUALIFIED_BASE + extraLimit;

            if (marks1 <= notQualifiedLimit || marks2 <= notQualifiedLimit) 
                return QuizQualifyResult.NO.ToString();
            if (marks1 >= qualifiedLimit || marks2 >= qualifiedLimit) 
                return QuizQualifyResult.YES.ToString();
            return QuizQualifyResult.MAYBE.ToString();
        }
    }
}