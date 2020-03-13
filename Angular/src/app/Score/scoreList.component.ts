import { Component, OnInit } from '@angular/core';
import { IScore } from './score';
import { ScoreService } from './score.service';
import webix = require('webix');


@Component({
    selector: 'score-list',
    templateUrl: 'app/score/scoreList.component.html',
    providers: [ScoreService]
})
export class ScoreListComponent {
    scores: IScore[];
    private ui: webix.ui.chart;
    constructor(private _scoreService: ScoreService) {
        let dataset: any = [
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
        this.ui = <webix.ui.chart>webix.ui({
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
                template: function (obj: number) {
                    return (obj % 25 ? "" : obj)
                }
            },
            data: dataset
        });
    }

    ngOnInit() {
        this._scoreService.getScores().subscribe((scoreData) => this.scores = scoreData);
    }

 
   
}