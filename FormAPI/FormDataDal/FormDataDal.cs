using Dapper;
using FormAPI.Context;
using FormAPI.Model;

namespace FormAPI.FormDataDal
{
    public class FormDataDal1
    {
        private readonly DapperContext _context;

        public FormDataDal1(DapperContext context)
        {
            _context = context;
            
        }

        public string TestDal(FormModel form)
        {
            if(form == null)
            {
                return "Payload is empty";
            }
            else
            {
                using (var connection = _context.CreateConnection()) 
                {
                    connection.Open();
                    var query = "INSERT INTO FormData (first_name, last_name, E_Mail, address) VALUES (@FirstName, @LastName, @EMail, @Address)";
                    var parameters = new DynamicParameters();
                    parameters.Add("@FirstName", form.first_name);
                    parameters.Add("@LastName", form.last_name);
                    parameters.Add("@EMail", form.E_Mail);
                    parameters.Add("@Address", form.address);

                    var result = connection.Execute(query,parameters);
                    return $"Test Done, {result} rows affected.";
                }
            }
        }
        }
}
