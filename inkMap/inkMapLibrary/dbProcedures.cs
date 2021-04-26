using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utilities;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace InkMapLibrary
{
    public class dbProcedures
    {
        DBConnect dBConnect = new DBConnect();

        public DataSet getVerificationInformation(int accountID)
        {
            SqlCommand procedure = new SqlCommand();
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.CommandText = "TP_VerifyAccountInfo";

            SqlParameter accountInfo = new SqlParameter("@accountID", accountID);
            accountInfo.Direction = ParameterDirection.Input;
            procedure.Parameters.Add(accountInfo);

            DataSet responseData = dBConnect.GetDataSetUsingCmdObj(procedure);
            return responseData;
        }

        public DataSet getaccountidfromemail(string email)
        {
            SqlCommand procedure = new SqlCommand();
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.CommandText = "TP_getaccountid";

            SqlParameter accountInfo = new SqlParameter("@email", email);
            accountInfo.Direction = ParameterDirection.Input;
            procedure.Parameters.Add(accountInfo);

            DataSet responseData = dBConnect.GetDataSetUsingCmdObj(procedure);
            return responseData;
        }

        public DataSet getverification(int accountid)
        {
            SqlCommand procedure = new SqlCommand();
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.CommandText = "TP_checkVerification";

            SqlParameter accountInfo = new SqlParameter("@accountID", accountid);
            accountInfo.Direction = ParameterDirection.Input;
            procedure.Parameters.Add(accountInfo);

            DataSet responseData = dBConnect.GetDataSetUsingCmdObj(procedure);
            return responseData;
        }

        public DataSet getaccounttype(int accountid)
        {
            SqlCommand procedure = new SqlCommand();
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.CommandText = "TP_GetAccountType";

            SqlParameter accountInfo = new SqlParameter("@accountID", accountid);
            accountInfo.Direction = ParameterDirection.Input;
            procedure.Parameters.Add(accountInfo);

            DataSet responseData = dBConnect.GetDataSetUsingCmdObj(procedure);
            return responseData;
        }

        public DataSet getcustomerinfo(int accountid)
        {
            SqlCommand procedure = new SqlCommand();
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.CommandText = "TP_getCustomerInfo";

            SqlParameter accountInfo = new SqlParameter("@accountID", accountid);
            accountInfo.Direction = ParameterDirection.Input;
            procedure.Parameters.Add(accountInfo);

            DataSet responseData = dBConnect.GetDataSetUsingCmdObj(procedure);
            return responseData;
        }

        public DataSet getprofileimage(int accountid)
        {
            SqlCommand procedure = new SqlCommand();
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.CommandText = "TP_getprofileimage";

            SqlParameter accountInfo = new SqlParameter("@accountID", accountid);
            accountInfo.Direction = ParameterDirection.Input;
            procedure.Parameters.Add(accountInfo);

            DataSet responseData = dBConnect.GetDataSetUsingCmdObj(procedure);
            return responseData;
        }


        public int updateProfileImage(int accountid, string title, string type, byte [] data, int length)
        {
            SqlCommand procedure = new SqlCommand();
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.CommandText = "TP_UploadProfilePic";

            SqlParameter account = new SqlParameter("@accountid", accountid);
            account.Direction = ParameterDirection.Input;
            procedure.Parameters.Add(account);

            SqlParameter imgtitle = new SqlParameter("@title", title);
            imgtitle.Direction = ParameterDirection.Input;
            procedure.Parameters.Add(imgtitle);

            SqlParameter imgtype = new SqlParameter("@type", type);
            imgtype.Direction = ParameterDirection.Input;
            procedure.Parameters.Add(imgtype);

            SqlParameter imgdata = new SqlParameter("@data", data);
            imgdata.Direction = ParameterDirection.Input;
            procedure.Parameters.Add(imgdata);

            SqlParameter imglength = new SqlParameter("@length", length);
            imglength.Direction = ParameterDirection.Input;
            procedure.Parameters.Add(imglength);


            int response = dBConnect.DoUpdateUsingCmdObj(procedure);
            return response;
        }

        public int updateAccountVerification(int accountid)
        {
            SqlCommand procedure = new SqlCommand();
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.CommandText = "TP_updateVerificationCode";

            SqlParameter verificationValue = new SqlParameter("@accountid", accountid);
            verificationValue.Direction = ParameterDirection.Input;
            procedure.Parameters.Add(verificationValue);

            int response = dBConnect.DoUpdateUsingCmdObj(procedure);
            return response;
        }
    }
}