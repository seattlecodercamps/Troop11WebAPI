namespace MegaTron.Services {

    export class MovieService {
        private MovieResource;

        public listMovies() {
            return this.MovieResource.query();
        }

        constructor($resource: ng.resource.IResourceService) {
            this.MovieResource = $resource('/api/movies');
        }
    }
    angular.module('MegaTron').service('movieService', MovieService);
    export class CheeseService {
        private CheeseResource;

        public listCheese() {
            return this.CheeseResource.query();
        }

        constructor($resource: ng.resource.IResourceService) {
            this.CheeseResource = $resource('/api/cheese/:id' );
        }
        public newCheese(newcheese) {
            return this.CheeseResource.save(newcheese).$promise;
        }
        public deleteCheese(id) {
            return this.CheeseResource.remove({ id: id }).$promise;
        }
    }
    angular.module('MegaTron').service('cheeseService', CheeseService);
    export class MyService {

    }
    angular.module('MegaTron').service('myService', MyService);
    }
