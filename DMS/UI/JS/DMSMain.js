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

    DMSMain.prototype.HandleSuccess = function (successText) {
        alert(successText);
    };

    DMSMain.prototype.SelectAllCheckboxes = function (className, selected) {
        var elements = $('.' + className);

        for (i = 0; i < elements.length; i++) {
            elements[i].checked = selected;
        }
    }

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
                            },
                            Close: function ()
                            { $(this).dialog("close"); }
                        },
                modal: true,
                width: 450,
                height: 280,
                title: 'Create docket!'
            });

            popupContainer.load(
                '/Docket/CreateNew.aspx',
                {},
                function (responseText, textStatus, XMLHttpRequest) {

                    var array = ['DMS-Docket-InventionName', 'DMS-Docket-InventorName', 'DMS-Docket-AppType'];

                    for (i = 0; i < array.length; i++)
                        $('#' + array[i]).tooltip({ disabled: true });

                    popupContainer.dialog("open");
                }
            );

        };

        Docket.prototype.Save = function () {

            if (this.Validate()) {

                var data = {
                    actionKey: "SaveDocket",
                    inventionName: $("#DMS-Docket-InventionName").val(),
                    inventorName: $("#DMS-Docket-InventorName").val(),
                    appType: $("#DMS-Docket-AppType").val()
                };

                $.ajax({
                    url: "/ActionFactory/Action.aspx",
                    metod: 'POST',
                    dataType: 'json',
                    data: data,
                    success: function (result) {
                        if (result.success == "True") {
                            dmsMain.HandleSuccess('Successfully made new docket with the id: ' + result.docketId);
                            $('#DMS-popup').dialog("close");
                            dmsMain.docket.Init();
                        } else {
                            dmsMain.HandleError(result.errorMessage);
                        }
                    },
                    error: function (result) {
                        dmsMain.HandleError(result.errorMessage);
                    }
                });
            }
        };

        Docket.prototype.Validate = function () {

            var array = ['#DMS-Docket-InventionName', '#DMS-Docket-InventorName', '#DMS-Docket-AppType'];

            var success = true;

            for (i = 0; i < array.length; i++) {

                var element = $(array[i]);

                if (element.val().trim() == '') {
                    success = false;
                    $(array[i]).addClass('ui-state-error style');
                    $(array[i]).tooltip({ disabled: false });
                } else {
                    $(array[i]).removeClass('ui-state-error style');
                    $(array[i]).tooltip({ disabled: true });
                }
            }

            return success;
        };

        Docket.prototype.SetDeleted = function () {

            // Get checkboxes
            var checkboxes = $('.DMS-Docket-Selector');

            var docketIds = '';

            for (i = 0; i < checkboxes.length; i++) {
                if (checkboxes[i].checked) {
                    docketIds += checkboxes[i].id + '|';
                }
            }

            // remove the last |
            docketIds = docketIds.substr(0, docketIds.length - 1);

            var data = {
                actionKey: "DeactivateDocket",
                reason: 'DELETE',
                deleted: 'True',
                docketIds: docketIds
            };

            $.ajax({
                url: "/ActionFactory/Action.aspx",
                metod: 'POST',
                dataType: 'json',
                data: data,
                success: function (result) {

                    if (result.success == "True") {
                        dmsMain.HandleSuccess('Successfully deleted');
                        dmsMain.docket.Init();
                    } else {
                        dmsMain.HandleError(result.errorMessage);
                    }
                },
                error: function (result) {
                    dmsMain.HandleError(result.errorMessage);
                }
            });

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
