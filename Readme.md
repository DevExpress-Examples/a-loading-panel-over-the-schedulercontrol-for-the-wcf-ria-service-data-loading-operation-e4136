# A loading panel over the SchedulerControl for the WCF RIA Service data loading operation


<p>This example illustrates how to display a loading panel over the SchedulerControl while appointment data is loaded via WCF RIA Services (see <a href="http://documentation.devexpress.com/#Silverlight/CustomDocument5728"><u>Lesson 1 - Bind a Scheduler to Data Using WCF RIA Services</u></a>). Since the SchedulerControl does not include a built-in loading panel, you need to use a separate panel and display it manually. Note that we provide a standalone <strong>WaitIndicator </strong>panel that is defined in the <strong>DevExpress.Xpf.Core</strong> namespace. You can use it in the following manner:<br />
</p>

```xaml
<dxc:WaitIndicator DeferedVisibility="{Binding Source={StaticResource ResourceKey=domainDataSourceAppointments}, Path=IsBusy}"/>


```

<p>Here is a sample screenshot that illustrates this functionality in action:</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/a-loading-panel-over-the-schedulercontrol-for-the-wcf-ria-service-data-loading-operation-e4136/12.1.5+/media/407604b9-ddf2-4eb9-a88d-1bf904cae101.png"></p><p>Alternatively, you can create any custom panel. For instance, check the solution provided in the <a href="https://www.devexpress.com/Support/Center/p/Q417433">Show Loading Panel</a> ticket.</p><p>Prior to running this example, it is required to register a CarsXtraScheduling database on your local SQL Server instance. You can download the corresponding SQL scripts from the <a href="https://www.devexpress.com/Support/Center/p/E215">How to bind ASPxScheduler to MS SQL Server database</a> example.</p>

<br/>


