using System;
using System.Collections.Generic;
using Training.Task6.Entity;
using Training.Task6.DAL.Interfaces;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace Training.Task6.DAL
{
    public class AwardDAL : IAwardDAL
    {
        private static Dictionary<int, Award> _allAward = new Dictionary<int, Award>();
        private string path;
        public AwardDAL()
        {
            CreateFile();
            ReadFileAward();
        }
        public void Add(Award award)
        {
            var lastid = _allAward.Keys.Count > 0 ? _allAward.Keys.Max() : 0;
            award.Id = lastid + 1;
            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine(JsonConvert.SerializeObject(award));
                _allAward.Add(award.Id, award);
            }
        }
        public void DeleteById(int id)
        {
            _allAward.Remove(id);
            WriterFileAward();
        }

        public IEnumerable<Award> GetAll()
        {
            return _allAward.Values;
        }
        private void CreateFile()
        {
            try
            {
                path = Path.GetFullPath("../../../Training.Task6.BD/Award.txt");
                using (var wreater = new StreamWriter(path, true)) { }
            }
            catch (Exception)
            {
                path = Path.Combine(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName, "Training.Task6.BD\\Award.txt");
                using (var wreater = new StreamWriter(path, true)) { }
            }
        }
        private void WriterFileAward()
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (var item in _allAward.Values)
                {

                    writer.WriteLine(JsonConvert.SerializeObject(item));
                }
            }
        }
        private void ReadFileAward()
        {
            using (var reader = new StreamReader(path))
            {
                while (reader.Peek() >= 0)
                {
                    var award = JsonConvert.DeserializeObject<Award>(reader.ReadLine());
                    _allAward.Add(award.Id, award);
                }
            }
        }

        public void EditingAward(int awardId, string title, string pathImage)
        {
            _allAward[awardId] = new Award()
            {
                Id = awardId,
                Title = title,
                Path_image = pathImage
            };
            WriterFileAward();
        }
    }
}
