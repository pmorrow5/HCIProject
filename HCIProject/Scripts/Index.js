$(function () {

  //click event handler for btnAddFundingPartner
  $("#btnAddSemesterPlan").on("click", function () {

    var fragment = document.createElement('<div Class="col-lg-3 col-md-3 col-sm-3"><div Class="panel panel-default" style="height:275px"><div id="btnAddCourse" Class="btn btn-primary glpyhicon glyphicon-plus" style="width:100%"></div></div></div>');

    var generateHere = document.getElementById("row1");


    generateHere.insertBefore(fragment, generateHere.firstChild);
    var test = "";
  });
})
