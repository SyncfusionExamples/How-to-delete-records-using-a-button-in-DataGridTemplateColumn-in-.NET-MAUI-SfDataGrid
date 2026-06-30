# How to delete records using a button in DataGridTemplateColumn in .NET MAUI SfDataGrid?
This demo shows How to delete records using a button in DataGridTemplateColumn in [.NET MAUI DataGrid?](https://help.syncfusion.com/maui/datagrid/overview) (SfDataGrid)
It demonstrates how to use a button inside a DataGridTemplateColumn to remove records directly from the SfDataGrid.

## Xaml
```
 <ContentPage.BindingContext>
     <local:OrderInfoRepository x:Name="viewModel"/>
 </ContentPage.BindingContext>

 <ContentPage.Content>
     <syncfusion:SfDataGrid x:Name="dataGrid" 
                            ColumnWidthMode="Auto"
                            GridLinesVisibility="Both" 
                            AutoGenerateColumnsMode="None"
                            HeaderGridLinesVisibility="Both"
                            ItemsSource="{Binding OrderInfoCollection}">
         <syncfusion:SfDataGrid.Columns>
             <syncfusion:DataGridNumericColumn MappingName="OrderID" HeaderText="Order ID"/>
             <syncfusion:DataGridTextColumn MappingName="CustomerID" HeaderText="Customer ID"/>
             <syncfusion:DataGridTextColumn MappingName="ShipCountry" HeaderText="Ship Country"/>
             <syncfusion:DataGridTextColumn MappingName="Customer" HeaderText="Customer"/>
             <syncfusion:DataGridTextColumn MappingName="ShipCity" HeaderText="Ship City"/>
             <syncfusion:DataGridTemplateColumn HeaderText="Delete Records" Format="C2">
                 <syncfusion:DataGridTemplateColumn.CellTemplate>
                     <DataTemplate>
                         <StackLayout HorizontalOptions="CenterAndExpand">
                             <Button Text="Delete" 
                                     BackgroundColor="#FF5252"
                                     TextColor="White"
                                     Clicked="Button_Clicked"
                                     CommandParameter="{Binding .}"
                                     HeightRequest="35"
                                     WidthRequest="80"
                                     FontSize="12"/>
                         </StackLayout>
                     </DataTemplate>
                 </syncfusion:DataGridTemplateColumn.CellTemplate>
             </syncfusion:DataGridTemplateColumn>
         </syncfusion:SfDataGrid.Columns>
     </syncfusion:SfDataGrid>
 </ContentPage.Content>

```
## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples.