namespace Application.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {
        //creating an entitiy cause I will need to create a user, create a website and also create a record for emails sent and also create a mailing list
        public Task Create (T entity);
        //updating a record
        public Task Update(T entity);
        //getting a record
        public Task<T> GetById(object id);
        public IEnumerable<T> GetAll();
        //deleting a record as well
        public Task Delete(T entity);
        //the purpose of this repository 
    }
}
