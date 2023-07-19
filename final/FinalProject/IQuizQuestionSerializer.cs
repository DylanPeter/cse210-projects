using System.Collections.Generic;

namespace DylanPeter.QuizGame.IO;
    public interface IQuizQuestionSerializer
    {
        IEnumerable<QuizQuestion> DeserializeQuestions();
    }
