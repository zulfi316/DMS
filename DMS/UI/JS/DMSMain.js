function DMSMain() {

    this.docket = new Docket();
    this.project = new Project();

    DMSMain.prototype.Init = function (landingPage) {

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

    DMSMain.prototype.UpdateMainStage = function (html) {

        $('#DMS-Main').html(html);
    };

    DMSMain.prototype.HandleError = function (errorText) {
        alert(errorText);
    };

/*****************************DOCKET which takes care of all the UI action for Dockets***********************************/
    function Docket() {

        Docket.prototype.Init = function () {
            $.ajax({
                url: "/Docket/DocketMain.aspx",
                success: function (result) {
                    dmsMain.UpdateMainStage(result);
                },
                error: function () {
                    dmsMain.HandleError("Failed to get projects!");
                }
            });
        };

        Docket.prototype.ShowDocketCreation = function () {

            var popupContainer = $('#DMS-popup');


            popupContainer.dialog({
                autoOpen: false,
                buttons:
                        {
                            Create: function () {
                                dmsMain.docket.Save();
                                $(this).dialog("close");
                            },
                            Close: function ()
                            { $(this).dialog("close"); }
                        },
                modal: true,
                title: 'Create docket!'
            });

            popupContainer.load(
                '/Docket/CreateNew.aspx',
                {},
                function (responseText, textStatus, XMLHttpRequest) {
                    popupContainer.dialog("open");
                }
            );

        };

        Docket.prototype.Save = function () {

            //if(this.Validate()){

            var data = {
                actionKey:      "SaveDocket",
                number:         $("#DMS-Docket-Number").val(),
                inventionName:  $("#DMS-Docket-InventionName").val(),
                inventorName:   $("#DMS-Docket-InventorName").val(),
                appType:        $("#DMS-Docket-AppType").val()
            };

            $.ajax({
                url: "/ActionFactory/Action.aspx",
                metod: 'POST',
                data: data,
                success: function (result) {
                    dmsMain.docket.Init();
                },
                error: function () {
                    dmsMain.HandleError("Failed to get projects!");
                }
            });
            //}
        }
    };
/**********************************************END OF DOCKET FUNCTION********************************************************************/


/*****************************PROJECT which takes care of all the UI action for projects***********************************/
    function Project() {

        Project.prototype.Init = function (docketId) {

            var data = 'DocketId=' + docketId;

            $.ajax({
                type: "POST",
                data: data,
                url: "/Project/ProjectMain.aspx",
                success: function (result) {
                    dmsMain.UpdateMainStage(result);
                },
                error: function () {
                    dmsMain.HandleError("Failed to get projects!");
                }
            });
        }


    }

}

/**********************************************END OF PROJECT FUNCTION********************************************************************/
