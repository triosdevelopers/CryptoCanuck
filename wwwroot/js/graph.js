// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
debugger;
var apiString = variable;
var graphTitle = coinName + ' Historical Price'
var seriesName = coinName + ' Price'
console.log(variable);
//var apiString = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=BTC&tsym=USD&limit=2000&api_key=d2b3e6d1c2375491a5fdc1edb5d12d98f1d2e0d2b54a5ef2d90c673a9738ee6c"
Highcharts.getJSON(apiString, function (data) {
    var data = data.Data.Data;
    //console.log(data);

    
    // split the data set into ohlc and volume
    var ohlc = [],
    volume = [],
    dataLength = data.length,
    i = 0;

    for (i; i < dataLength; i += 1) {
        ohlc.push([
            data[i].time*1000, // the date
            data[i].open, // open
            data[i].high, // high
            data[i].low, // low
            data[i].close // close
        ]);

        volume.push([
            data[i].time*1000, // the date
            data[i].volumeto // the volume
        ]);
    }

    var groupingUnits = [
        [
            'day', // unit name
            [1] // allowed multiples
        ], [
            'month',
            [1, 2, 3, 4, 6]
        ], [
            'minute',
            [5]
        ], [
            'hour',
            [1, 4]
        ]
    ];

    // create the chart
    Highcharts.stockChart('graphContainer', {

        plotOptions: {
            candlestick: {
                color: '#F68285',
                upColor: 'rgb(124,181,236)'
            }
        },
        rangeSelector: {
            allButtonsEnabled: true,
            buttons: [{
                type: 'month',
                count: 3,
                text: 'Day',
                dataGrouping: {
                    forced: true,
                    units: [['day', [1]]]
                }
            }, {
                type: 'year',
                count: 1,
                text: 'Week',
                dataGrouping: {
                    forced: true,
                    units: [['week', [1]]]
                }
            }, {
                type: 'all',
                text: 'Month',
                dataGrouping: {
                    forced: true,
                    units: [['month', [1]]]
                }
            }],
            buttonTheme: {
                width: 60
            },
            selected: 0
        },


        title: {
            text: graphTitle 
        },

        yAxis: [{
            labels: {
                align: 'right',
                x: -3
            },
            title: {
                text: 'Price'
            },
            height: '80%',
            lineWidth: 2,
            resize: {
                enabled: true
            }
        }, {
            labels: {
                align: 'right',
                x: -3
            },
            title: {
                text: 'Volume'
            },
            top: '80%',
            height: '20%',
            offset: 0,
            lineWidth: 2
        }],
        series: [{
            type: 'candlestick',
            name: seriesName,
            data: ohlc,
            dataGrouping: {
                units: groupingUnits
            }
        }, {
            type: 'column',
            name: 'Volume',
            data: volume,
            yAxis: 1,
            dataGrouping: {
                units: groupingUnits
            }
        }]
    });
});