using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QBLib.Models;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace QBWebApp.Pages
{
    [BindProperties]
    public class QBLogbookModel : PageModel
    {
        private readonly ILogger<QBLogbookModel> _logger;
        private readonly IConfiguration _QBconfig;
        
        public string Search { get; set; }
        public string QBName { get; set; }
        public string QBGradeYearLevel { get; set; }
        public string QBReasonForAdmission { get; set; }
        public string QBDate { get; set; }
        public string QBTime { get; set; }
        public string QBName2 { get; set; }
        public string QBGradeYearLevel2 { get; set; }
        public string QBReasonForAdmission2 { get; set; }
        public string QBDate2 { get; set; }
        public string QBTime2 { get; set; }
        public int QBId { get; set; }
        public int QBId2 { get; set; }
        public IEnumerable<QBModel.QBDisplay> QBlist { get; set; }
        public QBLogbookModel(ILogger<QBLogbookModel> logger,IConfiguration QBconfig)
        {
            _logger = logger;
            _QBconfig = QBconfig;


            var QBconn = new SqlConnection(_QBconfig.GetConnectionString("QBdb"));
            QBlist = QBconn.Query<QBModel.QBDisplay>("[dbo].[QBdisplay]",commandType:CommandType.StoredProcedure);


        }
        public IActionResult OnPostQBcreate()
        {
            var QBconn = new SqlConnection(_QBconfig.GetConnectionString("QBdb"));
            QBconn.Query("[dbo].[QBcreate]", new {
                @QBName= QBName,
                @QBGradeYearLevel =QBGradeYearLevel,
                @QBReasonForAdmission=QBReasonForAdmission,
                @QBDate=QBDate,
                @QBTime=QBTime

            }, commandType: CommandType.StoredProcedure);

            return RedirectToPage();
        }
        public IActionResult OnPostQBedit()
        {
            var QBconn = new SqlConnection(_QBconfig.GetConnectionString("QBdb"));
            QBlist = QBconn.Query<QBModel.QBDisplay>("[dbo].[QBdisplay]", commandType: CommandType.StoredProcedure);
            QBName = QBName2;
            QBGradeYearLevel=QBGradeYearLevel2;
            QBReasonForAdmission=QBReasonForAdmission2;
            QBDate=QBDate2;
            QBTime=QBTime2;
            QBId = QBId2;
            return Page();
        }
        public IActionResult OnPostQBsearch()
        {
            var QBconn = new SqlConnection(_QBconfig.GetConnectionString("QBdb"));
            QBlist = QBconn.Query<QBModel.QBDisplay>("[dbo].[QBsearch]", new { @QBkeyword = $"%{Search}%" }, commandType: CommandType.StoredProcedure);

            return Page();
        }

        public IActionResult OnPostQBupdate()
        {
            var QBconn = new SqlConnection(_QBconfig.GetConnectionString("QBdb"));
            QBconn.Query("[dbo].[QBupdate]", new
            {
                @QBId= QBId,
                @QBName = QBName,
                @QBGradeYearLevel = QBGradeYearLevel,
                @QBReasonForAdmission = QBReasonForAdmission,
                @QBDate = QBDate,
                @QBTime = QBTime

            }, commandType: CommandType.StoredProcedure);

            return RedirectToPage();
        }
        public IActionResult OnPostQBdelete()
        {
            var QBconn = new SqlConnection(_QBconfig.GetConnectionString("QBdb"));
            QBconn.Query("[dbo].[QBdelete]", new
            {
                @QBId = QBId

            }, commandType: CommandType.StoredProcedure);

            return RedirectToPage();
        }
    }
}
