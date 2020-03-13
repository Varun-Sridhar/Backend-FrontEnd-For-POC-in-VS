"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var score_service_1 = require("./score.service");
var webix = require("webix");
var ScoreListComponent = /** @class */ (function () {
    function ScoreListComponent(_scoreService) {
        this._scoreService = _scoreService;
        var dataset = [
            { id: 1, sales: 20, year: "02" },
            { id: 2, sales: 55, year: "03" },
            { id: 3, sales: 40, year: "04" },
            { id: 4, sales: 78, year: "05" },
            { id: 5, sales: 61, year: "06" },
            { id: 6, sales: 35, year: "07" },
            { id: 7, sales: 80, year: "08" },
            { id: 8, sales: 50, year: "09" },
            { id: 9, sales: 65, year: "10" },
            { id: 10, sales: 59, year: "11" }
        ];
        this.ui = webix.ui({
            view: "chart",
            width: 600,
            height: 250,
            type: "line",
            value: "#sales#",
            item: {
                borderColor: "#1293f8",
                color: "#ffffff"
            },
            line: {
                color: "#1293f8",
                width: 3
            },
            xAxis: {
                template: "'#year#"
            },
            offset: 0,
            yAxis: {
                start: 0,
                end: 100,
                step: 10,
                template: function (obj) {
                    return (obj % 25 ? "" : obj);
                }
            },
            data: dataset
        });
    }
    ScoreListComponent.prototype.ngOnInit = function () {
        var _this = this;
        this._scoreService.getScores().subscribe(function (scoreData) { return _this.scores = scoreData; });
    };
    ScoreListComponent = __decorate([
        core_1.Component({
            selector: 'score-list',
            templateUrl: 'app/score/scoreList.component.html',
            providers: [score_service_1.ScoreService]
        }),
        __metadata("design:paramtypes", [score_service_1.ScoreService])
    ], ScoreListComponent);
    return ScoreListComponent;
}());
exports.ScoreListComponent = ScoreListComponent;
//# sourceMappingURL=scoreList.component.js.map