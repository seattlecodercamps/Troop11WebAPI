namespace MegaTron.Controllers {

    export class HomeController {
        public message = 'Hello from the home page!';
        public cheese;
        public newCheese;
        public validationErrors = [];
        public pureValidationErrors = [];
        

        public fieldValidation(field) {
          
            var result = this.pureValidationErrors[field];
            debugger;
            return result;
        }

        constructor(private cheeseService:MegaTron.Services.CheeseService) {
            this.cheese = cheeseService.listCheese();
        }
        public submit() {
            this.cheeseService.newCheese(this.newCheese)
                .then(() => {
                    this.newCheese = {};
                    this.cheese = this.cheeseService.listCheese();
                })
                .catch((err) => {
                    this.pureValidationErrors = err.data;
                    // flatten errors
                    let validationErrors = [];
                    for (let prop in err.data) {
                        let propErrors = err.data[prop];
                        validationErrors = validationErrors.concat(propErrors);
                    }
                    this.validationErrors = validationErrors;
                });
        }

        public delete(id: number) {
            this.cheeseService.deleteCheese(id)
                .then(() => {
                    this.cheese = this.cheeseService.listCheese();

                })
                .catch(() => {
                    console.error("So close!");
                });
        }
    }



    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
