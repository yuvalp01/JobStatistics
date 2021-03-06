import * as React from 'react';
import Chart from 'react-google-charts';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../store';
import * as JobStatsStore from '../store/JobData';
import './FetchJobsStyle.css';

// At runtime, Redux will merge together...
type JobStatsProps =
  JobStatsStore.JobStatsState // ... state we've requested from the Redux store
  & typeof JobStatsStore.actionCreators // ... plus action creators we've requested
  & RouteComponentProps<{ startDateIndex: string }>; // ... plus incoming routing parameters


class FetchData extends React.PureComponent<JobStatsProps> {
  // This method is called when the component is first added to the document
  public componentDidMount() {
    this.ensureDataFetched();
  }

  // This method is called when the route parameters change
  public componentDidUpdate() {
    this.ensureDataFetched();
  }

  public render() {
    return (
      <React.Fragment>
        <h1 id="tabelLabel">Job Statistics</h1>
        {this.renderChart()}

      </React.Fragment>
    );
  }

  private ensureDataFetched() {
    const startDateIndex = parseInt(this.props.match.params.startDateIndex, 10) || 0;
    this.props.requestWeatherForecasts(startDateIndex);
  }


  private renderChart() {
    return (
      <div id="chart">
        <div style={{ display: 'flex', maxWidth: 1000 }}>
          <Chart
            width={1000}
            height={500}
            chartType="ComboChart"

            loader={<div>Loading Chart</div>}
            data={this.props.statsData}

            options={{
              title: 'Cumulative job views vs. prediction',
              titleTextStyle: { color: '#0a5b7b' },
              legend: { position: 'bottom', alignment: 'center' },
              colors: ['#96c03b', '#5bbdd2', '#dddddd'],
              pointSize: 30,
              series: {
                0: { targetAxisIndex: 0, pointShape: 'circle', pointSize: 8, title: 'sdf' },
                1: { pointShape: 'circle', pointSize: 8, lineDashStyle: [4, 4] },
                2: { type: 'bars', targetAxisIndex: 1 }
              },
              hAxis: {
                format: 'd/M/yyyy',
                gridlines: { count: 15 }
              },
              vAxes: {
                0: {
                  title: 'Job views',
                  viewWindow: {
                    max: 1500,
                    min: 0
                  }
                },
                1: {
                  title: 'Jobs',
                  viewWindow: {
                    max: 100,
                    min: 0
                  }
                }
              },

              chartArea: { width: '80%' },
              seriesType: 'line',
              tooltip: { isHtml: true },
              focusTarget: 'category'


            }}
            legendToggle
          />
        </div>
      </div>
    )
  }
}

export default connect(
  (state: ApplicationState) => state.jobStats, // Selects which state properties are merged into the component's props
  JobStatsStore.actionCreators // Selects which action creators are merged into the component's props
)(FetchData as any);
