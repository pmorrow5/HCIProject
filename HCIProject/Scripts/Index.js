$(function () {

  //click event handler for btnAddFundingPartner
  $("#btnAddSemesterPlan").on("click", function () {

    var semester = document.getElementById("row1");


    var nButtonNumber;
    var bButtonAdded = false;
    var fragment = document.createElement("div");

    fragment.innerHTML = '<div Class="col-lg-3 col-md-3 col-sm-3"><div Class="panel panel-default" style="height:275px"><div id="btnAddCourse" Class="btn btn-primary" style="margin-left:12px; margin-top:10px; width:90%;">Add Course</div></div></div></div>';

    var row1 = document.getElementById("row1");
    if (row1.children.length < 4) {
      nButtonNumber = row1.children.length;
      fragment.innerHTML = '<div Class="col-lg-3 col-md-3 col-sm-3"><div Class="panel panel-default" style="height:275px; overflow-y:auto;"><div id="btnAddCourseR1' + nButtonNumber + '" Class="btn btn-primary" style="margin-left:12px; margin-top:10px; width:90%;">Add Course</div></div></div></div>';

      row1.appendChild(fragment);
      
      $("#btnAddCourseR1" + nButtonNumber).on("click", function (e) {

        var fragment = document.createElement("div");
        fragment.innerHTML = '<input type="text" class="form-control" id="course" style="margin-left:12px;margin-top:10px;width:90%;">';
        var addCourseButton = document.getElementById("btnAddCourseR1" + nButtonNumber);

        var panelChildren = addCourseButton.parentNode.children;
        var panelChildrenLength = panelChildren.length;
        addCourseButton.parentNode.insertBefore(fragment, panelChildren[panelChildrenLength - 1]);
      });

    } else {

      var row2 = document.getElementById("row2");
      if (row2.children.length < 4) {
        nButtonNumber = row2.children.length;
        fragment.innerHTML = '<div Class="col-lg-3 col-md-3 col-sm-3"><div Class="panel panel-default" style="height:275px; overflow-y:auto;"><div id="btnAddCourseR2' + nButtonNumber + '" Class="btn btn-primary" style="margin-left:12px; margin-top:10px; width:90%;">Add Course</div></div></div></div>';

        row2.appendChild(fragment);
        
        $("#btnAddCourseR2" + nButtonNumber).on("click", function (e) {

          var fragment = document.createElement("div");
          fragment.innerHTML = '<input type="text" class="form-control" id="course" style="margin-left:12px;margin-top:10px;width:90%;">';
          var addCourseButton = document.getElementById("btnAddCourseR2" + nButtonNumber);

          var panelChildren = addCourseButton.parentNode.children;
          var panelChildrenLength = panelChildren.length;
          addCourseButton.parentNode.insertBefore(fragment, panelChildren[panelChildrenLength - 1]);
        });
      }
    }

    if (bButtonAdded) {
      //click event handler for btnAddFundingPartner
      
    }
  });
})
