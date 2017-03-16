@ModelType HCIProject.ViewModels.SemesterPlansViewModel

<div class="container body-content">
  <form class="form-inline" style="margin-bottom:25px;">
    <p style="color:red;" id="ErrorMessage"></p>
    <header>
      <input type="hidden" id="CurrentSemester" value="" />
      <datalist id="courseList">
        <option value="CSCE 155A - Computer Science I"></option>
        <option value="CHEM 109 - General Chemistry I"></option>
        <option value="CSCE 156 - Computer Science II"></option>
        <option value="CSCE 230 - Computer Organization"></option>
        <option value="CSCE 235 - Introduction to Discrete Structures"></option>
        <option value="CSCE 310 - Data Structures & Algorithms"></option>
        <option value="CSCE 322 - Programming Language Concepts"></option>
        <option value="CSCE 351 - Operating System Kernals"></option>
        <option value="CSCE 361 - Software Engineering"></option>
        <option value="CSCE 378 - Human-Computer Interaction"></option>
        <option value="MATH 106 - Calculus I"></option>
        <option value="MATH 107	- Calculus II"></option>
        <option value="MATH 208 - Calculus III"></option>
        <option value="MATH314 - Linear Algebra"></option>
        <option value="PHYS 211 - General Physics I"></option>
        <option value="STAT 380 - Stats & Applications"></option>
      </datalist>
      <datalist id="majorList">
        <option value="Computer Science"></option>
      </datalist>
      <datalist id="minorList">
        <option value="Mathematics"></option>
      </datalist>
    </header>
    <div class="form-group" style="width:25%">
      <label class="control-label">Select a Major to continue</label><br>
      <input id="major" class="form-control" type="text" list="majorList" placeholder="Select a Major" />
    </div>
    <div class="form-group" style="width:25%">
      <label class="control-label">Add a Minor</label><br>
      <input id="minorInput" class="form-control" type="text" list="minorList" placeholder="Add a Minor" />
    </div>
  </form>

  <div class="row col-sm-12" id="tabs">
    <ul class="nav nav-tabs">
      <li class="active"><a data-toggle="tab" href="#details">Major Details</a></li>
      <li><a data-toggle="tab" href="#requirements">Major Requirements</a></li>
      <li><a data-toggle="tab" href="#plans">Semester Plans</a></li>
      <li><a id="audit" data-toggle="tab" href="#audits">Degree Audit</a></li>
      <li><a data-toggle="tab" href="#help">Help</a></li>
    </ul>

    <div Class="tab-content">
      <!-- Details Tab -->
      <div id="details" Class="tab-pane fade in active">
        <ul class="nav nav-pills" style="margin: 20px 0px 20px 0px;">
          <li class="active"><a data-toggle="tab" href="#majorDetails">Major Details</a></li>
          <li><a data-toggle="tab" href="#majorDescription">Major Description</a></li>
        </ul>
        <!-- Cover Sheet Tab Section -->
        <div class="tab-content">
          <div id="majorDetails" class="tab-pane fade in active col-sm-12">
            <div Class="generated-style" style="overflow-y:auto;">
              <p Class="quick-points"><span class="quick-point-bold">COLLEGE:</span> Arts &amp; Sciences</p>
              <p Class="quick-points"><span class="quick-point-bold">MAJOR:</span> Computer Science</p>
              <p Class="quick-points"><span class="quick-point-bold">DEGREE OFFERED:</span> Bachelor of Arts Or Bachelor of Science</p>
              <p Class="quick-points"><span class="quick-point-bold">HOURS REQUIRED:</span> 120</p>
              <p Class="quick-points"><span class="quick-point-bold">MINIMUM CUMULATIVE GPA:</span> 2.0 for graduation</p>
              <p Class="quick-points"><span class="quick-point-bold">MINOR AVAILABLE:</span> Yes</p>
              <p Class="quick-points"><span class="quick-point-bold">ADVISOR:</span> Charles Riedesel</p>
            </div>
          </div>
          <div id="majorDescription" class="tab-pane fade col-sm-12">
            <p Class="faculty-list"><span class="faculty-list-bold">Chair: Matthew Dwyer, </span>256 Avery</p>
            <p Class="faculty-list"><span class="faculty-list-bold">Professors:</span> Deogun, Dwyer, Elbaum, Goddard, Jiang (emeritus), Ramamurthy, Reichenbach, Revesz, Rothermel, Samal, Seth (emeritus), Sincovec (emeritus), Surkan (emeritus),Variyam</p>
            <p Class="faculty-list"><span class="faculty-list-bold">Associate Professors:</span> Choueiry, Cohen, Costello (emeritus), Lu, Sarma, Scott, Soh, Srisa-An, Vuran, Xu</p>
            <p Class="faculty-list"><span class="faculty-list-bold">Assistant Professors:</span> Bradley, Cui, Detweiler, Duncan, Pierobon, Wei, Yan, Yu</p>
            <p Class="faculty-list"><span class="faculty-list-bold">Research Associate Professor:</span> Swanson</p>
            <p Class="faculty-list"><span class="faculty-list-bold">Research Assistant Professor:</span> Bockelman</p>
            <p Class="faculty-list"><span class="faculty-list-bold">Associate Professor of Practice:</span> Person</p>
            <p Class="faculty-list"><span class="faculty-list-bold">Assistant Professors of Practice:</span> Bourke, Hasan, Riedesel</p>
            <p Class="faculty-list"><span class="faculty-list-bold">Lecturers:</span> Patrick, Suing</p>
            <p Class="faculty-list"><span class="faculty-list-bold">Phone:</span> 402-472-2401</p>
            <p Class="faculty-list"><span class="faculty-list-bold">FAX:</span> 402-472-7767</p>
            <p Class="faculty-list"><span class="faculty-list-bold">Website:</span> <a href="http://cse.unl.edu">http://cse.unl.edu</a></p>
            <p Class="faculty-list"><span class="faculty-list-bold">email:</span> info@cse.unl.edu</p>
            <p Class="basic-text">The UNL Department of Computer Science And Engineering (CSE) offers Nebraska's only comprehensive program of higher education, research, and service outreach in computer science and computer engineering.</p>
            <p Class="basic-text">The CSE Department offers a challenging baccalaureate degree program in computer science that prepares graduates for professional practice as computer scientists, provides the basis for advanced studies in the field, And establishes a foundation for life-long learning And achievement. The BS degree in computer science Is accredited by the Computing Accreditation Commission of ABET, <a href="http://www.abet.org">http://www.abet.org</a>.</p>
            <p Class="basic-text">Consistent with these goals, the computer science baccalaureate program develops:</p>
            <ul>
              <li> The ability To solve a wide range Of computing-related problems. Studies include mathematical foundations, computer science theory, programming And software design, system components And design, application Of theory, experimentation, design tools And techniques, And documentation And maintenance.</li>
              <li> The ability To work With professionals In fields related To computing And/Or having computing applications. Studies include natural sciences And the completion Of at least one minor.</li>
              <li> Skills To quickly adapt To New work environments, assimilate New information, And solve New problems. Studies include application Of theory, experimentation, design tools And techniques, documentation And maintenance, And technical communications.</li>
              <li> The background And perspective necessary To pursue post-graduate education. Studies include computer science theory, application Of theory, experimentation, And life-Long learning/professional development.</li>
              <li> Abilities To work In conformance With societal needs And expectations. Studies include liberal arts And ethical/social issues.</li>
              <li> Insight into the world Of practicing professionals For collaborations, mutual support, And representing the profession To government And society. Studies include teamwork And life-Long learning/professional development, plus students are provided multiple opportunities For involvement In organizations such As ACM And UPE; undergraduate research; And service To the department And community.</li>
            </ul>
            <p Class="basic-text">The CSE Department also offers a degree of bachelor of science in computer engineering through the College of Engineering. All students majoring in the CSE Department should see their advisors during their first semester to make sure they understand the differences in the requirements of the two programs. Majors must consult with their advisors each semester for registration advising.</p>
            <p Class="header-paragraph"><span class="basic-text-bold">Introductory Courses.</span> Entering students may select from several introductory courses, according to their interests And as indicated by the CSE Placement Examination. The <span class="basic-text-bold">Computer Science I</span> courses (Of<a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155A">CSCE 155A</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155H">CSCE 155H</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155E">CSCE 155E</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155N">CSCE 155N</a>, And <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155T">CSCE 155T</a>) all provide a foundation in designing And programming computing solutions And prepare students for more advanced CSCE courses, including <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/156">CSCE 156</a>. These courses are designed to meet different interests. <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155A">CSCE 155A</a> Is designed for students majoring in computer science. <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155H">CSCE 155H</a> Is for honors students. <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155E">CSCE 155E</a> emphasizes computing for systems engineering, such as control systems, mobile computing, And embedded devices And Is designed for students majoring in computer engineering. <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155N">CSCE 155N</a> focuses on numerical And graphical computation in engineering And science, such as applied physics, working with time-sequence data, And matrix applications. <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155T">CSCE 155T</a> focuses on data And information processing, such as document Or database applications, online commerce, Or bioinformatics. <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/156">CSCE 156</a> Is for students with a background in designing And programming computing solutions, such as Is provided by Computer Science I. <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/101">CSCE 101</a> Is for students seeking a broad introduction to computer science with brief instruction in computer programming.</p>
            <p Class="header-paragraph"><span class="header-paragraph-title">Graduate Programs.</span> The CSE Department offers several graduate degree programs: master of science in computer science, master of science in computer science with computer engineering specialization, master of science in computer science with bioinformatics specialization, doctor of philosophy in computer science, doctor of philosophy in engineering with computer engineering specialization, doctor of philosophy in computer science with bioinformatics specialization, And joint doctor of philosophy in computer science And mathematics. See the <span class="basic-text-ital">Graduate Studies Bulletin</span> for details.</p>
          </div>
        </div>
      </div>
      <!-- Requirements Tab -->
      <div id="requirements" Class="tab-pane fade">
        <ul class="nav nav-pills" style="margin: 20px 0px 20px 0px;">
          <li class="active"><a data-toggle="tab" href="#majorRequirements">Major Requirements</a></li>
          <li><a data-toggle="tab" href="#additionalMajorRequirements">Additional Major Requirements</a></li>
          <li><a data-toggle="tab" href="#minorRequirements">Minor Requirements</a></li>
        </ul>
        <div class="tab-content">
          <div id="majorRequirements" class="tab-pane fade in active col-sm-12">
            <div class="generated-style">
              <h4 class="title-2">Computer Science (45 hours)</h4>
              <p class="requirement-sec-1"><b>Computer Science Core (22-24 hrs)</b></p>
              <p class="requirement-sec-2"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/10">CSCE 10</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155A">CSCE 155A</a> (or <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155H">CSCE 155H</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155E">CSCE 155E</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155N">CSCE 155N</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155T">CSCE 155T</a>), <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/156">CSCE 156</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/230">CSCE 230</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/235">CSCE 235</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/251">CSCE 251</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/310">CSCE 310</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/322">CSCE 322</a>, and <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/361">CSCE 361</a></p>
              <p class="requirement-sec-2">Or for students in the J. S. Raikes School of Computer Science and Management: <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/183H">RAIK 183H</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/184H">RAIK 184H</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/283H">RAIK 283H</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/383H">RAIK 383H</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/230">CSCE 230</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/251">CSCE 251</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/322">CSCE 322</a>.</p>
              <p class="requirement-sec-1"><b>Depth Courses (6 hrs)</b></p>
              <p class="requirement-sec-3"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/351">CSCE 351</a> or <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/451">CSCE 451</a>, <span class="requirement-bold">and </span></p>
              <p class="requirement-sec-3"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/423">CSCE 423</a> or <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/428">CSCE 428</a></p>
              <p class="requirement-sec-1"><b>Technical Electives (9-11 hrs)</b></p>
              <p class="requirement-sec-3">Any CSCE/RAIK 3xx or 4xx courses except <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/390">CSCE 390</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/490">CSCE 490</a>, <span class="requirement-bold">and </span>RAIK courses lacking CSCE equivalents <span class="requirement-ital">(except that <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/301H">RAIK 301H</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/302H">RAIK 302H</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/384H">RAIK 384H</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/401H">RAIK 401H</a>, and <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/402H">RAIK 402H</a> are acceptable as technical electives)</span>.</p>
              <p class="requirement-sec-3">Up to 3 hours of <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/491">CSCE 491</a> can be used for technical electives, and an additional 3 hours can be used toward the 120 hours required for the degree.</p>
              <p class="requirement-sec-3">At most, one of <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/MATH/428">MATH 428</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/MATH/432">MATH 432</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/MATH/433">MATH 433</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/MATH/439">MATH 439</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/MATH/450">MATH 450</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/MATH/452">MATH 452</a></p>
              <p class="requirement-sec-3">At least 6 credit hours of technical electives must be other than <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/399H">CSCE 399H</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/491">CSCE 491</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/493">CSCE 493</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/498">CSCE 498</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/301H">RAIK 301H</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/302H">RAIK 302H</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/401H">RAIK 401H</a>, and <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/402H">RAIK 402H</a>.</p>
              <p class="requirement-sec-1"><b>Senior Design Experience (6 hrs)</b></p>
              <p class="requirement-sec-3"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/486">CSCE 486</a> (or <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/381H">RAIK 381H</a> or <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/382H">RAIK 382H</a>), <span class="requirement-bold">and</span> <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/487">CSCE 487</a> (or <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/302H">RAIK 302H</a> or <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/402H">RAIK 402H</a>). <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/486">CSCE 486</a> and <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/487">CSCE 487</a> are to be taken in consecutive semesters.</p>
              <p class="header-paragraph">Students completing the Jeffrey S. Raikes School of Computer Science and Management automatically satisfy the technical electives and senior design experience requirements and need only <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/251">CSCE 251</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/322">CSCE 322</a>, and the 6 hours of depth courses to satisfy the computer science requirements.</p>
              <h4 class="title-2">Mathematics (15 hours)</h4>
              <p class="requirement-sec-2"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/MATH/106">MATH 106</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/MATH/107">MATH 107</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/MATH/314">MATH 314</a>, and <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/STAT/380">STAT 380</a></p>
              <h4 class="title-2">Science (12 hours)</h4>
              <p class="basic-text-no-indent">Must take at least 12 credit hours of courses intended for science/engineering majors and must include at least one laboratory. The CSE Department has identified the following five disciplines with their acceptable courses:</p>
              <p class="header-paragraph"><span class="header-paragraph-title">Chemistry:</span> <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CHEM/109">CHEM 109</a></span>, <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CHEM/110">CHEM 110</a></span>, <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CHEM/221">CHEM 221</a></span> (or <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CHEM/113">CHEM 113</a></span>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CHEM/114">CHEM 114</a>, <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CHEM/116">CHEM 116</a></span>)</p>
              <p class="header-paragraph"><span class="header-paragraph-title">Physics and Astronomy:</span> <span class="requirement-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/PHYS/141">PHYS 141</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/PHYS/142">PHYS 142</a></span>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/PHYS/211">PHYS 211</a>, <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/PHYS/221">PHYS 221</a></span>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/PHYS/212">PHYS 212</a>, <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/PHYS/222">PHYS 222</a></span>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/PHYS/213">PHYS 213</a>, <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/PHYS/223">PHYS 223</a></span>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/ASTR/204">ASTR 204</a>, <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/ASTR/224">ASTR 224</a></span></p>
              <p class="header-paragraph"><span class="header-paragraph-title">Biological Sciences:</span> <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/BIOS/109">BIOS 109</a></span>, <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/BIOS/111">BIOS 111</a></span>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/BIOS/112">BIOS 112</a>, <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/BIOS/112L">BIOS 112L</a></span>, <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/BIOS/205">BIOS 205</a></span>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/BIOS/206">BIOS 206</a>, <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/BIOS/207">BIOS 207</a>,</span> <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/LIFE/120">LIFE 120</a> &amp;<span class="basic-text-bold"> <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/LIFE/120L">LIFE 120L</a></span>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/LIFE/121">LIFE 121</a> &amp;<span class="basic-text-bold"> <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/LIFE/121L">LIFE 121L</a></span></p>
              <p class="header-paragraph"><span class="header-paragraph-title">Earth and Atmospheric Sciences:</span> <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/GEOG/155">GEOG 155</a></span>, <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/GEOL/101">GEOL 101</a></span>, <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/GEOL/103H">GEOL 103H</a></span>, <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/GEOL/210">GEOL 210</a></span>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/GEOL/410">GEOL 410</a>, <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/METR/100">METR 100</a></span>, <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/METR/205">METR 205</a></span>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/METR/370">METR 370</a></p>
              <p class="header-paragraph"><span class="header-paragraph-title">Anthropology:</span> <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/ANTH/242">ANTH 242</a>, <span class="basic-text-bold"><a class="course" href="https://bulletin.unl.edu/undergraduate/courses/ANTH/242L">ANTH 242L</a></span></p>
              <p class="header-paragraph"><span class="basic-text-bold">NOTE:</span> Bold face type indicates a lab course or that a lab is included with the course.</p>
              <p class="header-paragraph"><span class="header-paragraph-title">Program Assessment.</span> In order to assist the department in evaluating the effectiveness of its programs, majors will be required in their senior year to complete a written exit survey.</p>
              <p class="basic-text">Results of participation in these assessment activities will in no way affect a students GPA or graduation.</p>
              <h3 class="title-1" id="tracksoptionsconcentrationsemphases-requirements">Tracks/Options/Concentrations/Emphases Requirements</h3>
              <h4 class="title-2">Focus</h4>
              <p class="basic-text">A computer science major has the option of declaring a Focus in one of the areas listed below. Students who, in addition to meeting all computer science requirements listed above, receive a grade of C or better in each of three technical elective courses from one focus area below will receive a notice from the Department of Computer Science and Engineering stating that they received the degree bachelor of science in computer science with a Focus in their chosen area.</p>
              <h5 class="title-3">The Focus areas are as follows:</h5>
              <p class="header-paragraph"><span class="header-paragraph-title">Informatics:</span> <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/410">CSCE 410</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/411">CSCE 411</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/413">CSCE 413</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/464">CSCE 464</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/470">CSCE 470</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/471">CSCE 471</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/472">CSCE 472</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/473">CSCE 473</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/474">CSCE 474</a></p>
              <p class="header-paragraph"><span class="header-paragraph-title">Artificial Intelligence:</span> <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/421">CSCE 421</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/475">CSCE 475</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/476">CSCE 476</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/478">CSCE 478</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/479">CSCE 479</a></p>
              <p class="header-paragraph"><span class="header-paragraph-title">Computer and Networking Systems:</span> <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/430">CSCE 430</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/432">CSCE 432</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/434">CSCE 434</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/435">CSCE 435</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/455">CSCE 455</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/456">CSCE 456</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/462">CSCE 462</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/465">CSCE 465</a></p>
              <p class="header-paragraph"><span class="header-paragraph-title">Foundations:</span> <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/421">CSCE 421</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/423">CSCE 423</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/424">CSCE 424</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/428">CSCE 428</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/440">CSCE 440</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/477">CSCE 477</a></p>
              <p class="header-paragraph">In addition, up to 3 hours of <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/498">CSCE 498</a> Computer Problems (undergraduate research) can be used in any focus area. Some offerings of <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/496">CSCE 496</a> Special Topics may be substituted in an appropriate area. See your advisor for more details.</p>
              <p class="basic-text">A Focus is in addition to all major requirements. Thus, no course used by a student to fulfill a major requirement can also be applied to a Focus.</p>
              <p class="basic-text">Customized Focus Areas are possible. The department chair, in consultation with relevant faculty members and the undergraduate advisor, may approve a customized Focus Area proposed by a student. See your advisor for more information.</p>
              <p class="basic-text">To declare a Focus, see your advisor.</p>
              <h3 class="title-1" id="minor-requirements">Minor Requirements</h3>
              <p class="basic-text">The Plan A minor enables students to develop expertise in an additional academic area. Completing <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/MATH/208">MATH 208</a> (in addition to the major requirements) meets the Plan A minor requirement for mathematics. See your advisor for more information.</p>
              <p class="basic-text">Students who wish to take a cohesive block of courses that crosses departmental or even college lines should consider the Individualized Program of Studies minor offered by the College or a business minor offered by the College of Business Administration.</p>
            </div>
          </div>
          <div id="additionalMajorRequirements" class="tab-pane fade col-sm-12">
            <h4 class="title-2">Grade Rules</h4>
            <b class="title-2">Pass/No Pass Limits</b>
            <p class="basic-text">Departmental permission to take major or minor courses for Pass/No Pass credit must be obtained. Request forms are available in the Arts and Sciences Advising Center, 107 Oldfather Hall.</p>
            <h4 class="title-1" id="course-level-requirement">Course Level Requirement</h4>
            <p class="basic-text">13 hours of the CSCE courses must be at the 400 level for students not completing the J. S. Raikes School of Computer Science and Management.</p>
          </div>
          <div id="minorRequirements" class="tab-pane fade col-sm-12">
            <h4 class="title-2">Minor in Computer Science</h4>
            <p class="header-paragraph"><span class="header-paragraph-title">For students </span><em class="header-paragraph-title">not</em><span class="header-paragraph-title"> enrolled in the J. S. Raikes School of Computer Science and Management:</span> 18 hours of computer science courses, including one of <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155A">CSCE 155A</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155H">CSCE 155H</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155E">CSCE 155E</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155N">CSCE 155N</a>, or <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/155T">CSCE 155T</a>; at least one of <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/156">CSCE 156</a> or <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/311">CSCE 311</a>; and at least 3 hours of CSCE courses at the 300 level or above, but excluding CSCE courses explicitly designated as not counting toward the minor.</p>
            <p class="header-paragraph"><span class="header-paragraph-title">For students enrolled in the J. S. Raikes School of Computer Science and Management: </span>18 hours of computer science courses, including <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/183H">CSCE 183H</a>/<a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/183H">RAIK 183H</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/184H">CSCE 184H</a>/<a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/184H">RAIK 184H</a>, and <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/283H">CSCE 283H</a>/<a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/283H">RAIK 283H</a>. For the remaining 7 hours, students may count any CSCE courses <span class="requirement-ital">(or RAIK courses cross-listed as CSCE courses)</span> numbered 200 or above <span class="requirement-ital">(except <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/CSCE/235">CSCE 235</a> and courses designated as not counting toward the minor)</span> and up to 3 hours for a RAIK Design Studio course (<a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/301H">RAIK 301H</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/302H">RAIK 302H</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/401H">RAIK 401H</a>, <a class="course" href="https://bulletin.unl.edu/undergraduate/courses/RAIK/402H">RAIK 402H</a>).</p>
          </div>
        </div>
      </div>
      <!-- Semster Plans Tab -->
      <div id="plans" Class="tab-pane fade col-sm-12">
        <div id="btnAddSemesterPlan" Class="btn btn-primary" style="margin:10px;">Add Semester</div>
        <div Class="container">
          <div Class="panel panel-default">
            <div Class="row" id="row1">
            </div>
            <div Class="row" id="row2">
            </div>
          </div>
        </div>
      </div>
      <!-- Degree Audit Tab -->
      <div id="audits" Class="tab-pane fade col-sm-12">
        <div class="requirement Status_OK  category_HIDDEN   rname_ASCN  rtabx_04" id="req-9510168a-0b91-4f19-933a-0e00135d0d9e" rname="ASCN" pseudo="ASCN" rqdsubreq="2" rqdcount="0" rqdgpa="0.00000" rqdhours="0.00000" maxhours="999.00000" authcode1="" authcode2="">
          <div class="reqHeaderTable">
            <h3 class="sr-only">Requirement: </h3>
            <div class="reqStatusGroup">
              <div class="glyphicon glyphicon-remove"></div>
            </div>  <div class="reqText">
              <h4>UNL ADMISSION REQUIREMENTS</h4>(Processed using new Admission Standards)
            </div>
          </div>
        </div>
        <div class="requirement Status_NONE  category_HIDDEN   rname_ASC60HR  rtabx_08" id="req-3f2107ba-c583-48a9-a478-b31a0bc24e7f" rname="ASC60HR" pseudo="ASC60HR" rqdsubreq="0" rqdcount="0" rqdgpa="0.00000" rqdhours="0.00000" maxhours="999.00000" authcode1="" authcode2="">
          <div class="reqHeaderTable">
            <div class="reqStatusGroup">
              <div class="glyphicon glyphicon-remove"></div>
            </div>
            <h4>COMMUNITY COLLEGE TRANSFER CREDIT - 60-HOUR LIMIT</h4>
          </div>
        </div>
        <div class="reqBody">

          <div class="auditSubrequirements">
            <div class="subrequirement" id="subreq-7e496728-916a-4837-b753-43f0904852ea" pseudo="ASC60HR" rqdsubreq="0" rqdgpa="0.00000" rqdhours="60.00000" maxhours="60.00000">
              <div class="subreqBody">
                <div class="subrequirement-buttons"></div>
                <span class="subreqTitle">A maximum of 60 hours from 2-year, technical and<br>international schools may apply toward total hours.<br><br>Applicability of transfer course work toward specific<br>degree requirements may be subject to change if the<br>60-hour rule has been exceeded. Please contact your<br>college advising office for appropriate adjustments.</span>
              </div>
            </div>
          </div>
          <hr>
        </div>

        <div class="requirement Status_NO  category_Total_Hours/GPA   rname_ASCHRS-1  rtabx_09" id="req-e8f524ae-f618-4c28-8fa8-c55e01e0a47e" rname="ASCHRS-1" pseudo="ASCHRS-1" rqdsubreq="3" rqdcount="0" rqdgpa="0.00000" rqdhours="0.00000" maxhours="120.00000" authcode1="" authcode2="">
          <div class="reqHeaderTable">
            <h4>
              Requirement: General Graduation Requirements
            </h4>
            <div class="reqStatusGroup">
              <div class="glyphicon glyphicon-remove"></div>
            </div>  <div class="reqText">
              <b>GENERAL GRADUATION REQUIREMENTS</b>
            </div>
          </div>
          <div class="reqBody">
            <div class="auditSubrequirements">
              <ul>
                <li>A minimum 2.00 GPA required for graduation.</li>
                <li>Complete 30 hours in residence at UNL.</li>
                <li>A maximum of 12 hours of Military Science, Naval Science, Aerospace Studies, First Aid, Orientation and Study Skills courses may apply toward total hours.</li>
              </ul>
            </div>
            <hr>
          </div>
        </div>

        <div class="requirement Status_NO  category_ACE   rname_ACE  rtabx_13" id="req-152b601d-10be-4760-b280-d32adc5881b3" rname="ACE" pseudo="ACE" rqdsubreq="10" rqdcount="0" rqdgpa="0.00000" rqdhours="0.00000" maxhours="999.00000" authcode1=" " authcode2=" ">
          <div class="reqHeaderTable">
            <h3 class="sr-only">Requirement: Achievement Centered Educ</h3>
            <div class="reqStatusGroup">
              <div class="glyphicon glyphicon-remove"></div>
            </div>  <div class="reqText">
              <div class="requirement-buttons"></div>
              <div class="reqHeader">					</div>
              <h4>ACE: ACHIEVEMENT-CENTERED EDUCATION</h4>
              <ul>
                <li>No more than 3 courses may be taken from any one dept in ACE Outcomes 4-10.</li>
                <li>An ACE course approved for more than one outcome will fulfill one ACE outcome only.</li>
              </ul>
              <br>
            </div>
          </div>
        </div>
        <div class="reqBody">

          <div class="auditSubrequirements">
            <div class="subrequirement" id="subreq-70b5afc1-c4f2-4a67-8b99-ad437198c3c7" pseudo="ACE1" rqdsubreq="0" rqdgpa="0.00000" rqdhours="3.00000" maxhours="999.90000">
              <div class="subreqBody">
                <div class="subrequirement-buttons"></div>
                <b><span class="subreqTitle">ACE 1. Written Texts Incorporating Research and Knowledge Skills</span></b>
              </div>
            </div>
            <div class="subrequirement" id="subreq-8ee3c529-e53b-4618-8a3e-71865b15b594" pseudo="ACE2" rqdsubreq="0" rqdgpa="0.00000" rqdhours="3.00000" maxhours="999.90000">
              <div class="subreqBody">
                <div class="subrequirement-buttons"></div>
                <b><span class="subreqTitle">ACE 2. Communication Skills</span></b>
              </div>
            </div>
            <div class="subrequirement" id="subreq-dac75e1e-135b-40bf-9c21-e8730a89b237" pseudo="ACE3" rqdsubreq="0" rqdgpa="0.00000" rqdhours="3.00000" maxhours="999.90000">
              <div class="subreqBody">
                <div class="subrequirement-buttons"></div>
                <b><span class="subreqTitle">ACE 3. Mathematical, Computational, Statistical or Formal Reasoning Skills</span></b>

              </div>
            </div>
            <div class="subrequirement" id="subreq-fe5bb330-83e1-4fc8-b77c-5a452a811b05" pseudo="ACE4" rqdsubreq="0" rqdgpa="0.00000" rqdhours="3.00000" maxhours="999.90000">
              <div class="subreqBody">
                <div class="subrequirement-buttons"></div>
                <b><span class="subreqTitle">ACE 4. Study of Scientific Methods and Knowledge of the Natural and Physical World</span></b>
              </div>
            </div>
            <div class="subrequirement" id="subreq-4e966627-5bc9-49ea-9f83-aaacceed2da9" pseudo="ACE5" rqdsubreq="0" rqdgpa="0.00000" rqdhours="3.00000" maxhours="999.90000">
              <div class="subreqBody">
                <div class="subrequirement-buttons"></div>
                <b><span class="subreqTitle">ACE 5. Study of Humanities</span></b>
              </div>
            </div>
            <div class="subrequirement" id="subreq-d540e9e7-16dc-46ff-a962-cda49ca23155" pseudo="ACE6" rqdsubreq="0" rqdgpa="0.00000" rqdhours="3.00000" maxhours="999.90000">
              <div class="subreqBody">
                <div class="subrequirement-buttons"></div>
                <b><span class="subreqTitle">ACE 6. Study of Social Sciences</span></b>
              </div>
            </div>
            <div class="subrequirement" id="subreq-d26314fa-2159-4870-aa40-8eff05ad2442" pseudo="ACE7" rqdsubreq="0" rqdgpa="0.00000" rqdhours="3.00000" maxhours="999.90000">
              <div class="subreqBody">
                <div class="subrequirement-buttons"></div>
                <b><span class="subreqTitle">ACE 7. Study of the Arts to Understand Their Context and Significance</span></b>
              </div>
            </div>
            <div class="subrequirement" id="subreq-f31d2cb0-3895-40d0-82f9-614fd00fdcee" pseudo="ACE8" rqdsubreq="0" rqdgpa="0.00000" rqdhours="3.00000" maxhours="999.90000">
              <div class="subreqBody">
                <div class="subrequirement-buttons"></div>
                <b><span class="subreqTitle">ACE 8. Ethical Principles, Civics and Stewardship and Their Importance to Society</span></b>
              </div>
            </div>
            <div class="subrequirement" id="subreq-5b60389a-cf05-49ac-8ad2-66bccc111bdb" pseudo="ACE9" rqdsubreq="0" rqdgpa="0.00000" rqdhours="3.00000" maxhours="999.90000">
              <div class="subreqBody">
                <div class="subrequirement-buttons"></div>
                <b><span class="subreqTitle">ACE 9. Global Awareness or Knowledge of Human Diversity through Analysis of an Issue</span></b>
              </div>
            </div>
            <div class="subrequirement" id="subreq-ff95e53f-740c-4d36-bc30-9eb3bdf38a29" pseudo="ACE10" rqdsubreq="1" rqdgpa="0.00000" rqdhours="3.00000" maxhours="999.90000">
              <div class="subreqBody">
                <div class="subrequirement-buttons"></div>
                <b>
                  <span class="subreqTitle">ACE 10. Integration of Abilities and Capacities in a Creative or Scholarly Product</span>
                </b>
              </div>
            </div>

          </div>
          <hr>
        </div>

        <div class="requirement Status_NO  category_Distribution   rname_ASCDIST  rtabx_14" id="req-e3cbcca6-9323-4e18-9149-0aa3deec9a36" rname="ASCDIST" pseudo="ASCDIST" rqdsubreq="5" rqdcount="0" rqdgpa="0.00000" rqdhours="0.00000" maxhours="999.00000" authcode1="" authcode2="">
          <div class="reqHeaderTable">
            <h3 class="sr-only">Requirement: ASC Distribution Reqt</h3>
            <div class="reqStatusGroup">
              <div class="glyphicon glyphicon-remove"></div>
            </div>  <div class="reqText">
              <div class="requirement-buttons"></div>
              <div class="reqHeader">					</div>
              <h4><div class="reqTitle">COLLEGE OF ARTS &amp; SCIENCES DISTRIBUTION REQUIREMENT</div></h4>
            </div>
          </div>
          <div class="reqBody">

            <div class="auditSubrequirements">
              <div class="subrequirement" id="subreq-039c4be0-40b3-4d3f-94d8-8387b08a8d22" pseudo="ASC-A" rqdsubreq="0" rqdgpa="0.00000" rqdhours="3.00000" maxhours="999.90000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <b><span class="subreqTitle">CDR A. Written Communication</span></b>
                </div>
              </div>
              <div class="subrequirement" id="subreq-426bd177-9c2b-490f-8178-3bb12f11d8a5" pseudo="ASC-B" rqdsubreq="1" rqdgpa="0.00000" rqdhours="4.00000" maxhours="999.90000">
                <div class="subreqBody">

                  <div class="subrequirement-buttons"></div>
                  <b><span class="subreqTitle">CDR B. Natural, Physical &amp; Mathematical Sciences</span></b>
                </div>
              </div>
              <div class="subrequirement" id="subreq-7cc1ec59-0ff8-4d92-a5bb-cdcd9fa38f18" pseudo="ASCLAB" rqdsubreq="1" rqdgpa="0.00000" rqdhours="0.00000" maxhours="0.00000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <b><span class="subreqTitle">CDR B. Natural/Physical Science Lab</span></b>
                </div>
              </div>
              <div class="subrequirement" id="subreq-85b3ffaf-e6bd-4a40-93b1-d2c611ebedcd" pseudo="ASC-C" rqdsubreq="0" rqdgpa="0.00000" rqdhours="3.00000" maxhours="999.90000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <b><span class="subreqTitle">CDR C. Humanities</span></b>

                </div>
              </div>
              <div class="subrequirement" id="subreq-5607771a-eeb8-4435-86ee-0d96c2fb8f81" pseudo="ASC-D" rqdsubreq="0" rqdgpa="0.00000" rqdhours="3.00000" maxhours="999.90000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <b><span class="subreqTitle">CDR D. Social Sciences</span></b>
                </div>
              </div>

            </div>
            <hr>
          </div>
        </div>

        <div class="requirement Status_IP  category_Language   rname_ASCLANG  rtabx_12" id="req-9cd57e2d-18ec-47e7-b901-9f0b66c58531" rname="ASCLANG" pseudo="ASCLANG" rqdsubreq="1" rqdcount="0" rqdgpa="0.00000" rqdhours="0.00000" maxhours="999.00000" authcode1="" authcode2="">
          <div class="reqHeaderTable">
            <h3 class="sr-only">Requirement: CDR E Lang Reqt</h3>
            <div class="reqStatusGroup">
              <div class="glyphicon glyphicon-remove"></div>
            </div>  <div class="reqText">
              <div class="requirement-buttons"></div>
              <div class="reqHeader">					</div>
              <h4><div class="reqTitle">COLLEGE OF ARTS &amp; SCIENCES DISTRIBUTION REQUIREMENT</h4>
              <br><b>CDR E: Language Requirement (Classical and Modern)</b>
              <ul>
                <li>Single Foreign Language Sequence (0-6 Hrs)</li>
              </ul>
            </div>
          </div>
        </div>

        <div class="requirement Status_OK  category_Breadth   rname_ASCCOMP-B  rtabx_15" id="req-ff7e64ef-e0fb-4c53-8634-7fbe130cc4c5" rname="ASCCOMP-B" pseudo="ASCDIST-B" rqdsubreq="1" rqdcount="0" rqdgpa="0.00000" rqdhours="0.00000" maxhours="999.00000" authcode1="" authcode2="">
          <div class="reqHeaderTable">
            <h3 class="sr-only">Requirement: Additional Breadth Reqt</h3>
            <div class="reqStatusGroup">
              <div class="glyphicon glyphicon-remove"></div>
            </div>  <div class="reqText">
              <div class="requirement-buttons"></div>
              <div class="reqHeader">					</div>
              <div class="reqTitle"><h4>COLLEGE OF ARTS &amp; SCIENCES DISTRIBUTION REQUIREMENT</h4><br><b>CDR F:  Additional Breadth Requirement</b>						</div>
              <ul>
                <li>Additional Breadth Requirement.</li>
                <li>Note: May not be used toward the primary major; may apply toward ancillary requirements and second majors.</li>
              </ul>
            </div>
          </div>
        </div>

        <div class="requirement Status_NO  category_Major   rname_ASCCOMP  rtabx_17" id="req-9371e280-d1e6-48b2-93fb-59f3c5547775" rname="ASCCOMP" pseudo="ASCCOMP" rqdsubreq="10" rqdcount="0" rqdgpa="0.00000" rqdhours="44.00000" maxhours="999.00000" authcode1=" " authcode2=" ">
          <div class="reqHeaderTable">
            <h4 class="sr-only">Requirement: Computer Science Major</h4>
            <div class="reqStatusGroup">
              <div class="glyphicon glyphicon-remove"></div>
            </div>  <div class="reqText">
              <div class="requirement-buttons"></div>
              <div class="reqHeader">					</div>
              <div class="reqTitle">
                <h4>COMPUTER SCIENCE MAJOR</h4>
                <ul>
                  <li>No grade in the Major can be lower than C.</li>
                  <li>No course may be taken Pass/No Pass.</li>
                </ul>
              </div>
            </div>
          </div>
          <div class="reqBody">

            <div class="auditSubrequirements">
              <div class="subrequirement" id="subreq-a7d4e928-0131-4bf2-b97e-99c55a9bc704" pseudo="ASCCOMP-CORE" rqdsubreq="5" rqdgpa="0.00000" rqdhours="0.00000" maxhours="999.90000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <b>
                    <span class="subreqTitle">Computer Science Core (16 Hrs).</span>
                  </b>
                </div>
              </div>
              <div class="subrequirement" id="subreq-28707393-6212-4f27-898a-32e167437f85" pseudo="ASCCOMP-COMCORE" rqdsubreq="3" rqdgpa="0.00000" rqdhours="0.00000" maxhours="999.90000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <b><span class="subreqTitle">Computer Science Common Core (8 Hrs).</span></b>
                </div>
              </div>
              <div class="subrequirement" id="subreq-98200818-0652-4d9d-9731-055c881c3ff2" pseudo="ASCCOMP-DEPTH" rqdsubreq="0" rqdgpa="0.00000" rqdhours="6.00000" maxhours="999.90000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <b>
                    <span class="subreqTitle">Computer Science Depth Courses (6 Hrs).</span>
                  </b>
                </div>
              </div>
              <div class="subrequirement" id="subreq-dd050a89-9ac1-40dd-b237-4a6833d61d07" pseudo="ASCCOMP-1DESIGN" rqdsubreq="0" rqdgpa="0.00000" rqdhours="3.00000" maxhours="999.90000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <b><span class="subreqTitle">Senior Design Experience (3 Hrs).</span></b>

                </div>
              </div>
              <div class="subrequirement" id="subreq-ec69fe38-8ed6-4cf2-aa33-1f3cae703ed6" pseudo="ASCCOMP-DESIGN" rqdsubreq="0" rqdgpa="0.00000" rqdhours="3.00000" maxhours="999.90000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <b><span class="subreqTitle">Senior Design Experience (3 Hrs).</span></b>

                </div>
              </div>
              <div class="subrequirement" id="subreq-9397cbdc-b8a3-4f97-8ca2-2da1d663c762" pseudo="ASCCOMP-TECH1" rqdsubreq="0" rqdgpa="0.00000" rqdhours="6.00000" maxhours="999.90000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <span class="subreqTitle">
                    <b>Technical Electives (6 Hrs)</b><br>
                    <ul>
                      <li>
                        Note: At least 6 hours of Technical Electives must be other than CSCE 399H, 491, 493, 498, RAIK 301H, 302H, 401H and 402H.
                      </li>
                    </ul>
                  </span>

                </div>
              </div>
              <div class="subrequirement" id="subreq-41380d3e-77df-4b14-a1df-355fc7ca930e" pseudo="ASCCOMP-TECH2" rqdsubreq="0" rqdgpa="0.00000" rqdhours="3.00000" maxhours="999.90000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <span class="subreqTitle"><b>Technical Electives (3-5 Hrs)</b><br></span>
                  <ul>
                    <li>
                      No more than 3 hours of CSCE 491 can be applied.
                    </li>
                  </ul>
                </div>
              </div>
              <div class="subrequirement" id="subreq-2993562f-6c2f-4f51-8bad-d7ddc8f72f28" pseudo="ASCCOMP-400LVL" rqdsubreq="0" rqdgpa="0.00000" rqdhours="13.00000" maxhours="0.00000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <span class="subreqTitle"><b>400-Level Requirement</b><br></span>
                  <ul>
                    <li>
                      Note: 13 hours of the CSCE courses must be at the 400-level for students not completing the JS Raikes School of Computer Science &amp; Management.
                    </li>
                    <li>
                      A minimum of 6 UNL hours must be taken at the 300/400-level in the Major.
                    </li>
                    <li>
                      A minimum of 22 UNL hours must be taken in the Major
                    </li>
                  </ul>
                </div>
              </div>
            </div>
            <hr>
          </div>
        </div>

        <div class="requirement Status_OK  category_Ancillary   rname_ASCCOMP-N  rtabx_18" id="req-9e6dbae4-3387-40b8-8682-f5341635ace7" rname="ASCCOMP-N" pseudo="ASCCOMP-N" rqdsubreq="3" rqdcount="0" rqdgpa="0.00000" rqdhours="0.00000" maxhours="999.00000" authcode1="" authcode2="">
          <div class="reqHeaderTable">
            <h3 class="sr-only">Requirement: Comp Science Math Reqt</h3>
            <div class="reqStatusGroup">
              <div class="glyphicon glyphicon-remove"></div>
            </div>  <div class="reqText">
              <div class="requirement-buttons"></div>
              <div class="reqHeader">					</div>
              <h4><div class="reqTitle">COMPUTER SCIENCE MAJOR - MATHEMATICS COURSES</div></h4>
            </div>
          </div>
          <div class="reqBody">

            <div class="auditSubrequirements">
              <div class="subrequirement" id="subreq-9bb9c7eb-73b5-4c20-b7fe-a573e7b7510a" pseudo="ASCCOMPN-MATH" rqdsubreq="2" rqdgpa="0.00000" rqdhours="0.00000" maxhours="999.90000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <b><span class="subreqTitle">Calculus.</span></b>
                </div>
              </div>
              <div class="subrequirement" id="subreq-b69213d4-f5b4-42d7-9c84-c87cf13ac351" pseudo="ASCCOMPN-STAT" rqdsubreq="1" rqdgpa="0.00000" rqdhours="0.00000" maxhours="999.90000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <b><span class="subreqTitle">Statistics.</span></b>
                </div>
              </div>
              <div class="subrequirement" id="subreq-2c8dc737-449d-4970-aae0-1e673f781b10" pseudo="ASCCOMPN-ALG" rqdsubreq="1" rqdgpa="0.00000" rqdhours="0.00000" maxhours="999.90000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <b><span class="subreqTitle">Linear Algebra.</span></b>
                </div>
              </div>

            </div>
            <hr>
          </div>
        </div>

        <div class="requirement Status_IP  category_Major   rname_ASCCOMP-S  rtabx_19" id="req-54da7910-4fae-4aec-b779-7490e2295db6" rname="ASCCOMP-S" pseudo="ASCCOMP-S" rqdsubreq="2" rqdcount="0" rqdgpa="0.00000" rqdhours="0.00000" maxhours="999.00000" authcode1=" " authcode2=" ">
          <div class="reqHeaderTable">
            <h3 class="sr-only">Requirement: Comp Sci Science Reqt</h3>
            <div class="reqStatusGroup">
              <div class="glyphicon glyphicon-remove"></div>
            </div>  <div class="reqText">
              <div class="requirement-buttons"></div>
              <div class="reqHeader">					</div>
              <h4><div class="reqTitle">COMPUTER SCIENCE MAJOR - SCIENCE REQUIREMENT</div></h4>
            </div>
          </div>
          <div class="reqBody">

            <div class="auditSubrequirements">
              <div class="subrequirement" id="subreq-a46fe7cf-60ff-45b9-86e2-f5bfe27d0dfc" pseudo="ASCCOMP-SCI" rqdsubreq="0" rqdgpa="0.00000" rqdhours="12.00000" maxhours="999.90000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <b><span class="subreqTitle">Science Requirement.</span></b>

                </div>
              </div>
              <div class="subrequirement" id="subreq-829024a7-079c-45dc-b888-5a898b10f182" pseudo="ASCCOMP-LAB" rqdsubreq="1" rqdgpa="0.00000" rqdhours="0.00000" maxhours="0.00000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <b><span class="subreqTitle">Required Laboratory.</span></b>

                </div>
              </div>

            </div>
            <hr>
          </div>
        </div>

        <div id="minorPlanA" hidden="hidden">
          <div class="reqHeaderTable">
            <h3 class="sr-only">Requirement: Mathematics Minor</h3>
            <div class="reqStatusGroup">
              <div class="glyphicon glyphicon-remove"></div>
            </div>  <div class="reqText">
              <div class="requirement-buttons"></div>
              <div class="reqHeader">					</div>
              <h4><div id="minorPlanA" class="reqTitle">MATHEMATICS MINOR - PLAN A</div></h4>
              <ul>
                <li>No grade in the Minor can be lower than C.</li>
                <li>No Calculus course may be taken Pass/No Pass.</li>
                <li>No more than 3 hours of advanced Math may be taken taken Pass/No Pass.</li>
              </ul>
            </div>
          </div>
          <div class="reqBody">
            <hr>
          </div>
        </div>

        <div class="requirement Status_IP  category_Scientific_Base   rname_ASC-60SCI  rtabx_24" id="req-f908f205-3891-445d-9353-a2589b1354c1" rname="ASC-60SCI" pseudo="ASC-60SCI" rqdsubreq="1" rqdcount="0" rqdgpa="0.00000" rqdhours="60.00000" maxhours="999.00000" authcode1="" authcode2="">
          <div class="reqHeaderTable">
            <h3 class="sr-only">Requirement: Scientific Base Reqt</h3>
            <div class="reqStatusGroup">
              <div class="glyphicon glyphicon-remove"></div>
            </div>  <div class="reqText">
              <div class="requirement-buttons"></div>
              <div class="reqHeader">					</div>
              <h4><div class="reqTitle">BACHELOR OF SCIENCE - 60-HOUR SCIENTIFIC BASE</div></h4>
            </div>
          </div>
          <div class="reqBody">

            <div class="auditSubrequirements">
              <div class="subrequirement" id="subreq-a8f31b2a-88f5-41e4-a9f6-e1057d1693fd" pseudo="ASC60SCI" rqdsubreq="0" rqdgpa="0.00000" rqdhours="60.00000" maxhours="60.00000">
                <div class="subreqBody">
                  <div class="subrequirement-buttons"></div>
                  <b><span class="subreqTitle">Mathematics and Natural Sciences</span></b>
                </div>
              </div>
            </div>
            <hr>
          </div>
        </div>

        <div class="requirement Status_NO  category_Upper_Level   rname_ASC30HR-S  rtabx_25" id="req-bcf7c207-d182-46e1-b366-4b5e090d1eb1" rname="ASC30HR-S" pseudo="ASC30HR-S" rqdsubreq="2" rqdcount="0" rqdgpa="0.00000" rqdhours="30.00000" maxhours="999.00000" authcode1="" authcode2="">
          <div class="reqHeaderTable">
            <h4 class="sr-only">Requirement: 30 Hour Upper Level Reqt</h4>
            <div class="reqStatusGroup">
              <div class="glyphicon glyphicon-remove"></div>
            </div>  <div class="reqText">
              <div class="requirement-buttons"></div>
              <div class="reqHeader">					</div>
              <h4><div class="reqTitle">BACHELOR OF SCIENCE - 30-HOUR UPPER-LEVEL REQUIREMENT</div></h4>
              <ul>
                <li>Complete 30 hours of course work at the 300-level or above.</li>
                <li>A minimum of 15 hours at the 300-level or above<br>must be UNL hours</li>
              </ul>
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- Help Tab-->
    <div id="help" class="tab-pane fade col-sm-12" style="margin-top:15px">
      <div>
        <p>Our application is used to create a mock four – year plan for students at UNL. Our application allows the user to change majors, add minors, and add courses. As the major/minor changes, so do the mock degree audit and the major requirements.</p>

        <p>After selecting your major, your Details, Requirements, and Degree Audit Tabs will automatically update to show infomation pertaining to your major.</p>

        Tabs -
        <ul>
          <li>
            Details
            <ul>
              <li>Major information</li>
              <li>Contacts</li>
              <li>Required hours</li>
              <li>College specifics</li>
            </ul>
          </li>
          <li>
            Requirements
            <ul>
              <li>Detailed information about required courses</li>
            </ul>
          </li>
          <li>
            Semester Plan
            <ul>
              <li>
                Add courses
              </li>
            </ul>
          </li>
          <li>
            Degree Audit
            <ul>
              <li>Main reference when selecting courses</li>
              <li>Shows status of each individual requirement</li>
              <li>List of classes available for degree requirements</li>
            </ul>
          </li>
        </ul>
      </div>
    </div>
  </div>
</div>
</div>
@section scripts
  @Scripts.Render("~/bundles/index")
end section
