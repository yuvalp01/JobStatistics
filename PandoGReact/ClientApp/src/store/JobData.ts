import { Action, Reducer } from 'redux';
import { AppThunkAction } from './';

// -----------------
// STATE - This defines the type of data maintained in the Redux store.

export interface JobStatsState {
    isLoading: boolean;
    startDateIndex?: number;
    statsData: JobStatsObj[];
}

export interface JobStatsObj {
    date: string;
    temperatureC: number;
    temperatureF: number;
    summary: string;
}

// -----------------
// ACTIONS - These are serializable (hence replayable) descriptions of state transitions.
// They do not themselves have any side-effects; they just describe something that is going to happen.

interface RequestStatsAction {
    type: 'REQUEST_JOB_STATS';
    startDateIndex: number;
}

interface ReceiveStatsAction {
    type: 'RECEIVE_JOB_STATS';
    startDateIndex: number;
    statsData: JobStatsObj[];
}

// Declare a 'discriminated union' type. This guarantees that all references to 'type' properties contain one of the
// declared type strings (and not any other arbitrary string).
type KnownAction = RequestStatsAction | ReceiveStatsAction;

// ----------------
// ACTION CREATORS - These are functions exposed to UI components that will trigger a state transition.
// They don't directly mutate state, but they can have external side-effects (such as loading data).

export const actionCreators = {
    requestWeatherForecasts: (startDateIndex: number): AppThunkAction<KnownAction> => (dispatch, getState) => {
        // Only load data if it's something we don't already have (and are not already loading)
        const appState = getState();
        if (appState && appState.jobStats && startDateIndex !== appState.jobStats.startDateIndex) {
            fetch(`jobdata/chartData`)
                .then(response => response.json() as Promise<JobStatsObj[]>)
                .then(data => {
                    dispatch({ type: 'RECEIVE_JOB_STATS', startDateIndex: startDateIndex, statsData: data });
                });

            dispatch({ type: 'REQUEST_JOB_STATS', startDateIndex: startDateIndex });
        }
    }
};

// ----------------
// REDUCER - For a given state and action, returns the new state. To support time travel, this must not mutate the old state.

const unloadedState: JobStatsState = { statsData: [], isLoading: false };

export const reducer: Reducer<JobStatsState> = (state: JobStatsState | undefined, incomingAction: Action): JobStatsState => {

    if (state === undefined) {
        return unloadedState;
    }

    const action = incomingAction as KnownAction;
    switch (action.type) {
        case 'REQUEST_JOB_STATS':
            return {
                startDateIndex: action.startDateIndex,
                statsData: state.statsData,
                isLoading: true
            };
        case 'RECEIVE_JOB_STATS':
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            if (action.startDateIndex === state.startDateIndex) {
                return {
                    startDateIndex: action.startDateIndex,
                    statsData: action.statsData,
                    isLoading: false
                };
            }
            break;
    }

    return state;
};
