angular.module("umbraco")
    .controller("dbl.YouTubeListPlayer",
        function ($http, $scope, notificationsService) {
            var serviceRoot = '/Umbraco/Api/DareAPi/LoadPlayList';
            var dataTypeModel = $scope.model.value;
            var vm = this;
            var editMode =isObject(dataTypeModel);

            vm.playListId = editMode ? dataTypeModel.playListId : '';
            vm.videos = editMode ? dataTypeModel.videos : [];

            vm.loadVideos = function () {
                if (vm.playListId === '')
                    return;
                $http.get(serviceRoot + `?playListId=${vm.playListId}`).then(successCallback, errorCallback);
            }

            function successCallback(response) {
                var data = response.data;
                vm.videos = data.videos;

                $scope.model.value = {
                    playListId: vm.playListId,
                    videos: vm.videos,
                    nextPage: data.nextPage,
                    prevPage: data.prevPage,
                };

                notificationsService.success("Sync Complete", "playList successfully loaded");
            }

            function errorCallback(response) {
                notificationsService.error("Sync Failed", "syncronization has failed, please reload the page and try again.");
            }

            function isObject(obj) {
                return obj != null && obj.constructor.name === "Object"
            }
        });