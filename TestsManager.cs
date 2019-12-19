using Newtonsoft.Json;
using AppTests.ModelsDB;
using AppTests.ModelsGUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AppTests {
    public static class TestsManager
    {
        private const string UsersFileName = @"D:\SmartParkingData\users.json";
        private static List<User> users;

        static TestsManager()
        {
            LoadData();
            //WriteTestToFile(GetExampleTest(), "D:\\EngTest.json");
        }

        #region Working methods
        public static Test GetTest(string filename)
        {
            TestDB test = ReadTestFromFile(filename);
            return new Test(test.Name, test.Info, test.Duration,
                test.Questions.Select(t => QuestionFromDB(t)).ToList(),
                test.Criteries.Select(t => CriteriaFromDB(t)).ToList());
        }
        #endregion

        #region User methods & properties
        public static bool RegisterUser(User newUser)
        {
            users = Deserialize<List<User>>(UsersFileName);
            if (users.FirstOrDefault(t => t.Login == newUser.Login) != null)
                return false;
            users.Add(newUser);
            Serialize(UsersFileName, users);
            return true;
        }

        public static User Autorization(string login, string password)
        {
            users = Deserialize<List<User>>(UsersFileName);
            return users.FirstOrDefault(t => t.Login == login
                && t.Password == password);
        }
        #endregion

        #region Helper methods

        private static TestDB GetExampleTest()
        {
            return new TestDB()
            {
                Duration = 15,
                Name = "Тест на уровень английского языка",
                Info = "Тест состоит из 10 вопросов (от простого к сложному), " +
                    "ограничение по времени = 15 минут. Чтобы получить достоверный результат, " +
                    "старайтесь не использовать какие-либо справочные материалы. " +
                    "Желаем Вам удачи!",
                Questions = new List<QuestionDB>()
                {
                    new QuestionDB() { Number = 1, Text = "___________________your name?", BallsCorrect = 1, CorrectNum = 1,
                        Variants = new List<string>() { "Who’s", "What’s", "How’s", "Why’s" } },
                    new QuestionDB() { Number = 2, Text = "_________ old are you?", BallsCorrect = 1, CorrectNum = 2,
                        Variants = new List<string>() { "Who", "What", "How", "When" } },
                    new QuestionDB() { Number = 3, Text = "Выберите верное", BallsCorrect = 1, CorrectNum = 0,
                        Variants = new List<string>() { "I’m 17 years old", "I’ve 17 years old", "I are 17 years old", "I have 17 years old" } },
                    new QuestionDB() { Number = 4, Text = "______a bicycle?", BallsCorrect = 1, CorrectNum = 2,
                        Variants = new List<string>() { "You have", "Has you", "Do you have", "You’ve got" } },
                    new QuestionDB() { Number = 5, Text = "John___________ a tennis racket", BallsCorrect = 1, CorrectNum = 2,
                        Variants = new List<string>() { "hasn’t got", "haven’t", "not has", "haven’t got" } },
                    new QuestionDB() { Number = 6, Text = "Give it to______", BallsCorrect = 1, CorrectNum = 3,
                        Variants = new List<string>() { "he", "I", "she", "her" } },
                    new QuestionDB() { Number = 7, Text = "Выберите верное", BallsCorrect = 1, CorrectNum = 1,
                        Variants = new List<string>() { "He no can speak Spanish", "He can’t speak Spanish", "He can’t to speak Spanish", "He no speak Spanish" } },
                    new QuestionDB() { Number = 8, Text = "_______on the left in America", BallsCorrect = 1, CorrectNum = 1,
                        Variants = new List<string>() { "You mustn’t to drive", "You not must drive", "You mustn’t driving", "You mustn’t drive" } },
                    new QuestionDB() { Number = 9, Text = "Whose desk is this?___________", BallsCorrect = 1, CorrectNum = 3,
                        Variants = new List<string>() { "It’s of Robert", "It’s Robert", "It’s Robert’s", "It’s to Robert" } },
                },
                Criteries = new List<CriteriaDB>()
                {
                    new CriteriaDB() { Ball = 0, Status = "Плохо", StatusInfo = "Попробуйте еще раз"},
                    new CriteriaDB() { Ball = 3, Status = "Удовлетворительно", StatusInfo = "Уже лучше! Видно, что учебник вы читали"},
                    new CriteriaDB() { Ball = 5, Status = "Средне", StatusInfo = "Неплохо, но еще есть куда совершенствоваться"},
                    new CriteriaDB() { Ball = 7, Status = "Хорошо", StatusInfo = "Весьма неплохо! Еще немного теории..."},
                    new CriteriaDB() { Ball = 9, Status = "Отлично", StatusInfo = "Вы отлично знаете язык!"},
                }
            };
        }

        private static void WriteTestToFile(TestDB test, string filename)
        {
            Serialize(filename, test);
        }

        private static TestDB ReadTestFromFile(string filename)
        {
            return Deserialize<TestDB>(filename);
        }

        private static T Deserialize<T>(string fileName)
        {
            using (var sr = new StreamReader(fileName))
            {
                using (var jsonReader = new JsonTextReader(sr))
                {
                    var serializer = new JsonSerializer();
                    return serializer.Deserialize<T>(jsonReader);
                }
            }
        }

        private static void Serialize<T>(string fileName, T data)
        {
            using (var sw = new StreamWriter(fileName))
            {
                using (var jsonWriter = new JsonTextWriter(sw))
                {
                    var serializer = new JsonSerializer();
                    serializer.Serialize(jsonWriter, data);
                }
            }
        }

        private static Question QuestionFromDB(QuestionDB q)
        {
            return new Question(q.Number, q.Text, q.Variants, q.BallsCorrect, q.CorrectNum);
        }

        private static Criteria CriteriaFromDB(CriteriaDB c)
        {
            return new Criteria(c.Ball, c.Status, c.StatusInfo);
        }

        private static void LoadData()
        {
            users = Deserialize<List<User>>(UsersFileName);
        }

        #endregion
    }
}
