
//IF OUR PROGRAM CRASHES, THIS FUNCTION IS THE CULPRIT.
function getSemester() {
    var currentSemester = $("#CurrentSemester").val();

    var today = new Date();
    var month = today.getMonth()+1; //0 indexed
    var year = today.getFullYear();
    

    if (currentSemester == "") {
        if(month >= 6){
            currentSemester = "Spring ";

        } else {
            currentSemester = "Fall ";
        }

        currentSemester += year;
    } else if (currentSemester.split(" ")[0] == "Spring") {
        currentSemester = "Fall " + currentSemester.split(" ")[1];
    } else {
        currentSemester = "Spring " + (parseInt(currentSemester.split(" ")[1]) + 1);
    }

    $("#CurrentSemester").val(currentSemester);
    return currentSemester;
}

$(function () {
  $("#tabs").hide();
  $("#major").on("change", function () {
      if (this.value == "Computer Science") {
          $('#tabs').show();
          $('#ErrorMessage').hide();
      } else {
          $('#ErrorMessage')[0].innerHTML = "You must select Computer Science as your major.";
          $('#ErrorMessage').show();
          }
  });


  $("#audit").on("click", function () {
    $('#audit').css("background-color", "none");
  });

  //click event handler for btnAddFundingPartner
  $("#btnAddSemesterPlan").on("click", function () {

    var semester = document.getElementById("row1");
    
    var nButtonNumber;
    var bButtonAdded = false;
    var fragment = document.createElement("div");

    //I commented this out. WHY IS THIS HERE? ITS FUCKIN' WITH MY JAVASCRIPT FOR GetSemester() -- GetSemester is ran twice, once here and once in the if statement below
    //fragment.innerHTML = '<div Class="col-lg-3 col-md-3 col-sm-3"><div style="height:10%; text-align:center; font-size:x-large;">'+ getSemester() +'</div><div Class="panel panel-default" style="height:275px"><div id="btnAddCourse" Class="btn btn-primary" style="margin-left:12px; margin-top:10px; width:90%;">Add Course</div></div></div></div>';

    var row1 = document.getElementById("row1");
    if (row1.children.length < 4) {
      nButtonNumber = row1.children.length;
      fragment.innerHTML = '<div Class="col-lg-3 col-md-3 col-sm-3"><div style="height:10%; text-align:center; font-size:x-large;">'+ getSemester() +'</div><div Class="panel panel-default" style="height:275px; overflow-y:auto;"><div id="btnAddCourseR1' + nButtonNumber + '" Class="btn btn-primary" style="margin-left:12px; margin-top:10px; width:90%;">Add Course</div></div></div></div>';

      row1.appendChild(fragment);
      
      $("#btnAddCourseR1" + nButtonNumber).on("click", function (e) {
        var addCourseButton = document.getElementById("btnAddCourseR1" + nButtonNumber);
        var panelChildren = addCourseButton.parentNode.children;
        var panelChildrenLength = panelChildren.length;

        var fragment = document.createElement("div");
        fragment.innerHTML = '<input type="text" class="form-control" id="courseR1' + nButtonNumber + panelChildrenLength + '" list="courseList" style="margin-left:12px;margin-top:10px;width:90%;">';

        addCourseButton.parentNode.insertBefore(fragment, panelChildren[panelChildrenLength - 1]);
        $("#courseR1" + nButtonNumber + panelChildrenLength).on("change", function () {
          $('#audit').css("background-color", "gold");
        });
      });

    } else {

      var row2 = document.getElementById("row2");
      if (row2.children.length < 4) {
        nButtonNumber = row2.children.length;
        fragment.innerHTML = '<div Class="col-lg-3 col-md-3 col-sm-3"><div style="height:10%; text-align:center; font-size:x-large;">' + getSemester() + '</div><div Class="panel panel-default" style="height:275px; overflow-y:auto;"><div id="btnAddCourseR2' + nButtonNumber + '" Class="btn btn-primary" style="margin-left:12px; margin-top:10px; width:90%;">Add Course</div></div></div></div>';

        row2.appendChild(fragment);
        
        $("#btnAddCourseR2" + nButtonNumber).on("click", function (e) {
          var addCourseButton = document.getElementById("btnAddCourseR2" + nButtonNumber);
          var panelChildren = addCourseButton.parentNode.children;
          var panelChildrenLength = panelChildren.length;

          var fragment = document.createElement("div");
          fragment.innerHTML = '<input type="text" class="form-control" id="courseR2' + nButtonNumber + panelChildrenLength + '" list="courseList" style="margin-left:12px;margin-top:10px;width:90%;">';

          addCourseButton.parentNode.insertBefore(fragment, panelChildren[panelChildrenLength - 1]);

          $("#courseR2" + nButtonNumber + panelChildrenLength).on("change", function () {
            $('#audit').css("background-color", "gold");
          });
        });
      }
    }

    if (bButtonAdded) {
      //click event handler for btnAddFundingPartner
      
    }
  });
})
