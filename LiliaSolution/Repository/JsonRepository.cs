using Interface.Repository;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class JsonRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly string filePath;
        public JsonRepository()
        {
            filePath = $"JsonRepository{typeof(T).Name}.json";

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]");
            }
        }

        public int Create(T entity)
        {
            List<T> entities = GetAll().ToList();
            int maxId = entities.Count > 0 ? entities.Max(p => p.Id) : 0;
            entity.Id = maxId + 1;
            entities.Add(entity);

            SaveChanges(entities);

            return entity.Id;
        }

        public void Delete(params int[] ids)
        {
            List<T> entities = GetAll().ToList();
            entities.RemoveAll(p => ids.Contains(p.Id));
            SaveChanges(entities);
        }

        public T Get(int id)
        {
            return GetAll().First(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<T>>(json);
            }
        }

        public void Update(int id, T entity)
        {
            List<T> entities = GetAll().ToList();
            int index = entities.FindIndex(p => p.Id == entity.Id);
            if (index != -1)
            {
                entities[index] = entity;
                SaveChanges(entities);
            }
            else
            {
                throw new KeyNotFoundException("Entity not found");
            }
        }

        private void SaveChanges(List<T> entities)
        {
            string json = JsonConvert.SerializeObject(entities, Formatting.Indented);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(json);
            }
        }
    }
}
