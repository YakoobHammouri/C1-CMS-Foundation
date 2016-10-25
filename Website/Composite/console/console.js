import 'systemjs-hot-reloader/default-listener';

import React from 'react';
import { render } from 'react-dom';
import { Provider } from 'react-redux';
import configureStore from 'console/state/store.js';
import ConnectDockPanel from 'console/components/container/ConnectDockPanel.js';
import 'react-select/scss/default.scss!';
import 'fixed-data-table-2/dist/fixed-data-table.css!scss';
import 'console/console.scss!';
import 'console/iconIndex.js';

document.title = 'Orckestra CMS: ' + location.hostname;

const initialState = {
	logs: {
		'server-log/log': {
			'2016-10-07': [
				{
					timestamp: '2016-10-18 13:25:59.52',
					message: 'System.ComponentModel.Win32Exception (0x80004005): The system cannot find the file specified   at Composite.Web.Css.Less.ReparsePointUtils.GetSymbolicLinkTarget(DirectoryInfo symlink)\nat Composite.Web.Css.Less.ReparsePointUtils.GetDirectoryReparsePointTarget(String directoryPath)\nat Composite.Web.Css.Less.StylesHashing.FileHashCalculator.AddWatchesForSymbolicallyLinkedSubfolders(String folder)',
					title: 'LessCss',
					type: 'Error'
				},
				{
					timestamp: '2016-10-07 12:53:32.50',
					message: 'AppDomain 3 started at 12:53:32:48 in process 9456',
					title: 'ApplicationEventHandler',
					type: 'Information'
				},
				{
					timestamp: '2016-10-07 15:17:38.18',
					message: 'AppDomain 2 unloaded at 12:52:07:04',
					title: 'ApplicationEventHandler',
					type: 'Information'
				},
				{
					timestamp: '2016-10-07 15:17:46.84',
					message: 'AppDomain 2 ended at 12:52:06:49 in process 9456',
					title: 'ApplicationEventHandler',
					type: 'Information'
				},
				{
					timestamp: '2016-10-07 15:17:43.09',
					message: 'AppDomain 2 started at 07:26:25:70 in process 9456',
					title: 'ApplicationEventHandler',
					type: 'Information'
				},
				{
					timestamp: '2016-10-07 07:26:25.73',
					message: 'Starting Method',
					title: 'TreeServicesFacade.ExecuteElementAction',
					type: 'Verbose'
				},
				{
					timestamp: '2016-10-07 15:17:38.07',
					message: 'PackageDescription added to cache',
					title: 'PackageServerFacadeCache',
					type: 'Verbose'
				},
				{
					timestamp: '2016-10-07 15:17:42.05',
					message: 'PackageDescription cache miss',
					title: 'PackageServerFacadeCache',
					type: 'Verbose'
				},
				{
					timestamp: '2016-10-07 12:52:06.49',
					message: 'New console registred by \'admin\' id = \'key21762174422070313\'',
					title: 'ConsoleFacade',
					type: 'Verbose'
				},
				{
					timestamp: '2016-10-07 15:17:38.07',
					message: 'Finished: Initializing Entity Hooks (94 ms)',
					title: 'HookingFacade',
					type: 'Verbose'
				},
				{
					timestamp: '2016-10-07 12:52:07.04',
					message: 'Total time for: 79 ms',
					title: 'ElementHookRegistratorFacade',
					type: 'Verbose'
				}
			]
		}
	}
};
const store = configureStore(initialState);
function whenReadyRender() {
	if (document.readyState === 'complete') {
		render(
			<Provider store={store}>
				<ConnectDockPanel/>
			</Provider>,
			document.querySelector('body > div.entry')
		);
	}
}
document.onreadystatechange = whenReadyRender;
whenReadyRender();
