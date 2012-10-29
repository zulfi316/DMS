function DCMMain() {

    this.docket = new Docket();
    this.project = new Project();

    DCMMain.prototype.Init = function (landingPage) {

        var handler;
        switch (landingPage) {

            case 'Project':
                handler = this.project;
                break;
            default:
                handler = this.docket;
                break;
        }

        handler.Init();

    };

    DCMMain.prototype.UpdateMainStage = function (html) {
        document.getElementById("DCM.MainDiv").innerHTML = html;
    };

    DCMMain.prototype.HandleError = function (errorText) {
        alert(errorText);
    };

    function Docket() {

        Docket.prototype.Init = function () {
            $.ajax({
                type: "POST",
                url: "/Docket/DocketMain.aspx",
                success: function (result) {
                    dcmMain.UpdateMainStage(result);
                },
                error: function () {
                    dcmMain.HandleError("Failed to get projects!");
                }
            });
        }
    };


    function Project() {

        Project.prototype.Init = function (docketId) {
            // Get all projects for the selected Docket
            alert('Time Get projects for docketId: ' + docketId);
        }


    }

}