@ModelType ViewModels.SemesterPlansViewModel

<div class="row">
  TEST AGAIN
  <table class="table table-bordered table-striped sortable">
    <thead>
      <tr>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      @For Each sp In Model.SemesterPlans
        @<tr>
           @*<td>@Html.DisplayFor(Model)</td>*@
      </tr>
      Next

      <div id="btnAddSemesterPlan" class="btn btn-primary glpyhicon glyphicon-plus">BUTTON</div>
    </tbody>
  </table>
</div>
