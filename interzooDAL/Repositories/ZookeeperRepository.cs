using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using interzooDAL.Models;

namespace interzooDAL.Repositories
{
    public class ZookeeperRepository : BaseRepository<Zookeeper, int>
    {
        public ZookeeperRepository(string Cnstr) : base (Cnstr)
        {
            SelectOneCommand = "Select * from Zookeeper where idZookeeper=@idZookeeper";
            SelectAllCommand = "Select * from Zookeper";
            InsertCommand = @"INSERT INTO Zookeeper (FirstName, LastName,
            email, phone, birthday, photo, password) 
                                OUTPUT inserted.idZookeeper VALUES(@FirstName, @LastName, 
            @email, @phone, @birthday, @photo, @password)";

            UpdateCommand = @"UPDATE  Zookeeper
                           SET FirstName = @FirstName,  LastName = @LastName, Birthday = @birthday, Phone = @phone, Email = @email,  Password = @password>
                         WHERE IdZookeeper = @idZookeeper;";
            DeleteCommand = @"Delete from  Zookeeper  WHERE IdZookeeper = @idZookeeper;";
        }

        public Zookeeper VerifLogin(Zookeeper zookeeper)
        {
            SelectOneCommand = "Select * from Zookeeper where Email=@email and Password=@password";
            return base.getOne(Map, MapToDico(zookeeper));
        }

        public override IEnumerable<Zookeeper> GetAll()
        {
            return base.getAll(Map);
        }

        public override Zookeeper GetOne(int id)
        {
            Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
            QueryParameters.Add("idZookeeper", id);
            return base.getOne(Map, QueryParameters);
        }

        public override Zookeeper Insert(Zookeeper toInsert)
        {
            Dictionary<string, object> Parameters = MapToDico(toInsert);
            int id = base.Insert(Parameters);
            toInsert.IdZookeeper = id;
            return toInsert;
        }

        //internal IEnumerable<Zookeeper> GetAllFromGroup(int id)
        //{
        //    SelectAllCommand = "Select * from Zookeeper inner join MembreGroupe Mg on Membre.IdMEmbre= Mg.IdMembre WHERE Mg.idGroupe=@id";
        //    Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
        //    QueryParameters.Add("id", id);
        //    return base.getAll(Map, QueryParameters);

        //}

        public override bool Update(Zookeeper toUpdate)
        {
            Dictionary<string, object> Parameters = MapToDico(toUpdate);
            return base.Update(Parameters);

        }

        public override bool Delete(int id)
        {
            Dictionary<string, object> QueryParameters = new Dictionary<string, object>();
            QueryParameters.Add("@idZookeeper", id);
            return base.Delete(QueryParameters);

        }


        #region Mappers
        private Dictionary<string, object> MapToDico(Zookeeper toInsert)
        {
            Dictionary<string, object> p = new Dictionary<string, object>();
            p["idZookeeper"] = toInsert.IdZookeeper;
            p["FirstName"] = toInsert.FirstName;
            p["LastName"] = toInsert.LastName;
            p["birthday"] = toInsert.Birthday;
            p["phone"] = toInsert.Phone;
            p["email"] = toInsert.Email;
            p["password"] = toInsert.HashMDP;
            return p;
        }

        private Zookeeper Map(SqlDataReader arg)
        {
            return new Zookeeper()
            {
                IdZookeeper = (int)arg["idZookeeper"],
                FirstName = arg["FirstName"].ToString(),
                LastName = arg["LastName"].ToString(),
                Email = arg["email"].ToString(),
                Phone = (int)arg["phone"],
                Birthday = (DateTime)arg["birthday"]
                //casting 
            
                //WE CAN'T STORE PASSWORD FROM DB
                // MotDePasse= arg["MotDePasse"].ToString()
            };
        }
        #endregion
    }
}
            
       
