import * as React from 'react';
import { Redirect, Route } from 'react-router';
import Layout from './components/Layout';
import FetchJobData from './components/FetchJobData';

import './custom.css'

export default () => (
    <Layout>
        <Redirect exact from="/" to="fetch-data" />
        <Route path='/fetch-data/:startDateIndex?' component={FetchJobData} />
    </Layout>
);
