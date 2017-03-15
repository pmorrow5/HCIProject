@ModelType HCIProject.SemesterPlan
<link href="~/Content/semester_style.css" rel="stylesheet" />
<link href="~/Content/bootstrap.css" rel="stylesheet" />

<div class="semester-wrapper">
    <div class="semester-header form-control">
        getSemester();
    </div>
    <div class="semester-body">
        <ul id="spr17" style="list-style:none; padding-left:0;">
            <li class="add-course-box">
                <button id="btnAddCourse" type="button" class="btn btn-outline-secondary" style="width: 100%; display: block;" OnClick="ToggleSearch();">+ Add Course</button>
                <input id="txtSearch" type="text" autocomplete="on" name="classSearch" value="search for classes" style="display:none;"/>
            </li>
        </ul>
    </div>
</div>

<script>

   function ToggleSearch(){
       if (btnAddCourse == 0) {
           btnAddCourse.css('display') = 'block';
           txtSearch.css('display') = 'none';
       } else {
           $("#txtSearch").toggle();
           $("#btnAddCourse").toggle();
       }

       $("#txtSearch").focusout(function(){
           if (this.value.toString.trim == '' || this.value.toString.trim == this.defaultValue) {
               ToggleSearch();
           };
       })

    };

</script>