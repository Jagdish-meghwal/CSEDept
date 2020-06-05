using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Student_FeedbackForm : System.Web.UI.Page
{
    dbcode csedept = new dbcode();
    Auto id = new Auto();
    string DateNow = DateTime.Now.ToString("yyyy-MM-dd hh:mm tt");
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            btnSave.Visible = false;
            msgFails.Visible = false;
            msgsuccess.Visible = false;

            if (!IsPostBack)
            {
               
                getDetails();

            }


        }
        catch (Exception)
        {
            Response.Redirect("Dashboard.aspx");
        }
    }

  public void getDetails()
    {
        grdProfileData.DataSource = csedept.SelectQuery("select StudentFeedBackTbl.StudentID, StudentTbl.RollNo, StudentTbl.Name, StudentFeedBackTbl.Question, StudentFeedBackTbl.Answer, StudentFeedBackTbl.CreateDate from StudentFeedBackTbl inner join StudentTbl on StudentFeedBackTbl.StudentID = StudentTbl.ID where StudentFeedBackTbl.StudentID = '" + Session["Id"].ToString()+ "' and StudentFeedBackTbl.IsActive='1' ");
        grdProfileData.DataBind();
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        //try
        //{
        //    //string pid = Request.QueryString["pid"];
        //    foreach (GridViewRow row in grdProfileData.Rows)
        //    {
        //        if (row.RowType == DataControlRowType.DataRow)
        //        {
        //            //csedept.ReplaceChr(Page.Controls);

        //            RadioButton rdexecellent = row.FindControl("rdexecellent") as RadioButton;
        //            RadioButton rdgood = row.FindControl("rdgood") as RadioButton;
        //            RadioButton rdfair = row.FindControl("rdfair") as RadioButton;
        //            RadioButton rdbad = row.FindControl("rdbad") as RadioButton;

        //            HiddenField hdStudentID = row.FindControl("hdStudentID") as HiddenField;
        //            if (rdexecellent.Checked == true)
        //            {
        //                long FeedBackID = id.auto1("StudentFeedBackTbl", "ID");
        //                csedept.ExecuteQuery("Insert into StudentFeedBackTbl values (" + FeedBackID + ",'" + hdStudentID.Value + "','" + ddlStudentDepartment.SelectedValue + "','" + ddlStudentYear.SelectedValue + "','" + ddlStudentSemester.SelectedValue + "','" + hdStudentID.Value + "','" + txtfirstmarks.Text + "','" + txtsecondmarks.Text + "','" + txtavg.Text + "','" + txtassigmarks.Text + "','" + txttotalmarks.Text + "','" + DateNow + "','1')");
        //            }
        //            else
        //            {
        //                csedept.ExecuteQuery("update FillMarksTbl set FirstMidMarks = '" + txtfirstmarks.Text + "', SecondMidMarks = '" + txtsecondmarks.Text + "', AvgMidMarks = '" + txtavg.Text + "', AssiMarks = '" + txtassigmarks.Text + "', TotalMarks = '" + txttotalmarks.Text + "' where StudentID = '" + hdStudentID.Value + "' and DeptID = '" + ddlStudentDepartment.SelectedValue + "' and Year = '" + ddlStudentYear.SelectedValue + "' and Semester = '" + ddlStudentSemester.SelectedValue + "' and SubID = '" + ddlSubjects.SelectedValue + "' and IsActive = '1'");
        //            }
        //        }
        //    }
        //    msgsuccess.Visible = true;
        //    ddlStudentDepartment.ClearSelection();
        //    ddlStudentSemester.ClearSelection();
        //    ddlStudentYear.ClearSelection();
        //    ddlSubjects.ClearSelection();
        //    grdProfileData.DataSource = null;
        //    grdProfileData.DataBind();
        //    btnSave.Text = "Save";

        //}
        //catch (Exception)
        //{ }
    }


    //protected void btnSearch_Click(object sender, EventArgs e)
    //{
    //    //try
    //    //{
    //    //    string SubId = csedept.ExecuteScalar("select count(*) from FillMarksTbl where IsActive='1' and SubID = '" + ddlSubjects.SelectedValue + "' and IsActive='1'");
    //    //    if (int.Parse(SubId) > 0)
    //    //    {
    //    //        grdProfileData.DataSource = csedept.SelectQuery("select FillMarksTbl.ID,FillMarksTbl.StudentID, StudentTbl.RollNo, StudentTbl.Name, StudentTbl.FathersName,  FillMarksTbl.FirstMidMarks, FillMarksTbl.SecondMidMarks, FillMarksTbl.AvgMidMarks, FillMarksTbl.AssiMarks, FillMarksTbl.TotalMarks from FillMarksTbl inner join StudentTbl on FillMarksTbl.StudentID = StudentTbl.ID where FillMarksTbl.SubID = '" + ddlSubjects.SelectedValue + "' and StudentTbl.DeptID = '" + ddlStudentDepartment.SelectedValue + "' and StudentTbl.Year = '" + ddlStudentYear.SelectedValue + "' and StudentTbl.Semester = '" + ddlStudentSemester.SelectedValue + "' and StudentTbl.IsActive='1' and FillMarksTbl.IsActive='1'");
    //    //        grdProfileData.DataBind();
    //    //        btnSave.Text = "Update";
    //    //    }
    //    //    else
    //    //    {

    //    //        DataTable dtData = new DataTable();
    //    //        dtData = csedept.SelectQuery("select ID as [StudentID], RollNo, Name, FathersName from StudentTbl where DeptID = '" + ddlStudentDepartment.SelectedValue + "' and Year = '" + ddlStudentYear.SelectedValue + "' and Semester = '" + ddlStudentSemester.SelectedValue + "' and IsActive = '1'");
    //    //        dtData.Columns.Add("FirstMidMarks");
    //    //        dtData.Columns.Add("SecondMidMarks");
    //    //        dtData.Columns.Add("AvgMidMarks");
    //    //        dtData.Columns.Add("AssiMarks");
    //    //        dtData.Columns.Add("TotalMarks");
    //    //        grdProfileData.DataSource = dtData;
    //    //        grdProfileData.DataBind();
    //    //        btnSave.Text = "Save";
    //    //    }
    //    //    if (grdProfileData.Rows.Count > 0)
    //    //    {
    //    //        btnSave.Visible = true;
    //    //    }

    //    }
    //    //catch (Exception)
    //    //{ }
    //}

}