/*< Window x: Class = "BookCatalog.MainWindow"
        xmlns = "http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns: x = "http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns: d = "http://schemas.microsoft.com/expression/blend/2008"
        xmlns: mc = "http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns: local = "clr-namespace:BookCatalog.ViewModel"
        mc: Ignorable = "d" Background = "Azure"
        Name = "Window"
        Title = "MainWindow" Height = "600" Width = "950" >
    
        < Window.DataContext >
    
            < local:BookCatalogViewModel />
     
         </ Window.DataContext >
     
         < Grid >
     
             < Grid.RowDefinitions >
     
                 < RowDefinition Height = "60" />
      
                  < RowDefinition />
      
                  < RowDefinition />
      
              </ Grid.RowDefinitions >
      

              < Label Grid.Row = "0" FontWeight = "Bold" FontSize = "20" HorizontalAlignment = "Center" VerticalAlignment = "Center" Content = "Book catalog" />
                 

                         < DataGrid Grid.Row = "1" ItemsSource = "{Binding BooksList}"  AutoGenerateColumns = "False" Margin = "5" Name = "BookDG" IsReadOnly = "True" >
                            
                                        < DataGrid.Columns >
                            

                                            < DataGridTextColumn Header = "Book Id" Binding = "{Binding Id}" />
                               
                                               < DataGridTextColumn Header = "Name" Binding = "{Binding Name}" />
                                  
                                                  < DataGridTextColumn Header = "Author" Binding = "{Binding Author}" />
                                     
                                                     < DataGridTextColumn Header = "Description" Binding = "{Binding Description}" />
                                        
                                                        < DataGridTextColumn Header = "Price" Binding = "{Binding Price}" />
                                           
                                                           < DataGridTextColumn Header = "ISBN" Binding = "{Binding ISBN}" />
                                              
                                                              < DataGridTextColumn Header = "Picture" Binding = "{Binding Picture}" />
                                                 
                                                                 < DataGridTextColumn Header = "Description" Binding = "{Binding Description}" />
                                                    

                                                                        < DataGridTemplateColumn Header = "Update Book" >
                                                     
                                                                         < DataGridTemplateColumn.CellTemplate >
                                                     
                                                                             < DataTemplate >
                                                     
                                                                                 < Button Content = "Edit" Click = "UpdateProductForEdit" />
                                                        
                                                                                </ DataTemplate >
                                                        
                                                                            </ DataGridTemplateColumn.CellTemplate >
                                                        
                                                                        </ DataGridTemplateColumn >
                                                        

                                                                        < DataGridTemplateColumn Header = "Delete Book" >
                                                         
                                                                             < DataGridTemplateColumn.CellTemplate >
                                                         
                                                                                 < DataTemplate >
                                                         
                                                                                     < Button Content = "Delete" Command = "{Binding 
                                Path = DataContext.DeleteButtonClick,
                                RelativeSource ={ RelativeSource AncestorType = Window},
                                Mode = Default}"
                                    CommandParameter = "{Binding ElementName=BookDG,
                                Path = CurrentItem}"/>
                          </ DataTemplate >
  
                      </ DataGridTemplateColumn.CellTemplate >
  
                  </ DataGridTemplateColumn >
  


              </ DataGrid.Columns >
  
          </ DataGrid >
  

          < Grid Grid.Row = "2" >
   

               < Grid.ColumnDefinitions >
   
                   < ColumnDefinition />
   
                   < ColumnDefinition />
   
               </ Grid.ColumnDefinitions >
   

               < Border Grid.Column = "0" BorderBrush = "Black" BorderThickness = "1" Margin = "5" >
          
                          < StackPanel Margin = "5" >
           
                               < Label Content = "Add new book" HorizontalAlignment = "Center" VerticalAlignment = "Center" />
                

                                    < Grid Margin = "5" x: Name = "AddNewBookGrid" >
                    
                                            < Grid.ColumnDefinitions >
                    
                                                < ColumnDefinition />
                    
                                                < ColumnDefinition />
                    
                                            </ Grid.ColumnDefinitions >
                    

                                            < Grid.RowDefinitions >
                    
                                                < RowDefinition />
                    
                                                < RowDefinition />
                    
                                                < RowDefinition />
                    
                                                < RowDefinition />
                    
                                                < RowDefinition />
                    
                                                < RowDefinition />
                    
                                                < RowDefinition />
                    
                                            </ Grid.RowDefinitions >
                    

                                            < Label Grid.Row = "0" Grid.Column = "0" Content = "Name" />
                         
                                                 < TextBox Grid.Row = "0" Grid.Column = "1" Text = "{Binding NewBook.Name, Mode=TwoWay}" />
                              

                                                      < Label Grid.Row = "1" Grid.Column = "0" Content = "Author" />
                                   
                                                           < TextBox Grid.Row = "1" Grid.Column = "1" Text = "{Binding NewBook.Author}" />
                                        

                                                                < Label Grid.Row = "2" Grid.Column = "0" Content = "Year" />
                                             
                                                                     < TextBox Grid.Row = "2" Grid.Column = "1" Text = "{Binding NewBook.Year}" />
                                                  

                                                                          < Label Grid.Row = "3" Grid.Column = "0" Content = "ISBN" />
                                                       
                                                                               < TextBox Grid.Row = "3" Grid.Column = "1" Text = "{Binding NewBook.ISBN}" />
                                                            

                                                                                    < Label Grid.Row = "4" Grid.Column = "0" Content = "Picture" />
                                                                 
                                                                                         < TextBox Grid.Row = "4" Grid.Column = "1" Text = "{Binding NewBook.Picture}" />
                                                                      

                                                                                              < Label Grid.Row = "5" Grid.Column = "0" Content = "Description" />
                                                                           
                                                                                                   < TextBox Grid.Row = "5" Grid.Column = "1" Text = "{Binding NewBook.Description}" />
                                                                                

                                                                                                        < Button Grid.Row = "6" Grid.ColumnSpan = "2" Content = "Add" Margin = "5" Command = "{Binding AddButtonClick}" />
                                                                                         

                                                                                                             </ Grid >
                                                                                         

                                                                                                         </ StackPanel >
                                                                                         
                                                                                                     </ Border >
                                                                                         


                                                                                                     < Border Grid.Column = "1" BorderBrush = "Black" BorderThickness = "1" Margin = "5" >
                                                                                                
                                                                                                                < StackPanel Margin = "5" >
                                                                                                 
                                                                                                                     < Label Content = "Update book" HorizontalAlignment = "Center" VerticalAlignment = "Center" />
                                                                                                      

                                                                                                                          < Grid Margin = "5" x: Name = "UpdateBookGrid" >
                                                                                                          
                                                                                                                                  < Grid.ColumnDefinitions >
                                                                                                          
                                                                                                                                      < ColumnDefinition />
                                                                                                          
                                                                                                                                      < ColumnDefinition />
                                                                                                          
                                                                                                                                  </ Grid.ColumnDefinitions >
                                                                                                          

                                                                                                                                  < Grid.RowDefinitions >
                                                                                                          
                                                                                                                                      < RowDefinition />
                                                                                                          
                                                                                                                                      < RowDefinition />
                                                                                                          
                                                                                                                                      < RowDefinition />
                                                                                                          
                                                                                                                                      < RowDefinition />
                                                                                                          
                                                                                                                                      < RowDefinition />
                                                                                                          
                                                                                                                                      < RowDefinition />
                                                                                                          
                                                                                                                                      < RowDefinition />
                                                                                                          
                                                                                                                                  </ Grid.RowDefinitions >
                                                                                                          

                                                                                                                                  < Label Grid.Row = "0" Grid.Column = "0" Content = "Name" />
                                                                                                               
                                                                                                                                       < TextBox Grid.Row = "0" Grid.Column = "1" Text = "{Binding SelectedBook.Name}" />
                                                                                                                    

                                                                                                                                            < Label Grid.Row = "1" Grid.Column = "0" Content = "Author" />
                                                                                                                         
                                                                                                                                                 < TextBox Grid.Row = "1" Grid.Column = "1" Text = "{Binding SelectedBook.Author}" />
                                                                                                                              

                                                                                                                                                      < Label Grid.Row = "2" Grid.Column = "0" Content = "Year" />
                                                                                                                                   
                                                                                                                                                           < TextBox Grid.Row = "2" Grid.Column = "1" Text = "{Binding SelectedBook.Year}" />
                                                                                                                                        

                                                                                                                                                                < Label Grid.Row = "3" Grid.Column = "0" Content = "ISBN" />
                                                                                                                                             
                                                                                                                                                                     < TextBox Grid.Row = "3" Grid.Column = "1" Text = "{Binding SelectedBook.ISBN}" />
                                                                                                                                                  

                                                                                                                                                                          < Label Grid.Row = "4" Grid.Column = "0" Content = "Picture" />
                                                                                                                                                       
                                                                                                                                                                               < TextBox Grid.Row = "4" Grid.Column = "1" Text = "{Binding SelectedBook.Picture}" />
                                                                                                                                                            

                                                                                                                                                                                    < Label Grid.Row = "5" Grid.Column = "0" Content = "Description" />
                                                                                                                                                                 
                                                                                                                                                                                         < TextBox Grid.Row = "5" Grid.Column = "1" Text = "{Binding SelectedBook.Description}" />
                                                                                                                                                                      

                                                                                                                                                                                              < Button Grid.Row = "6" Grid.ColumnSpan = "2" Content = "Update" Margin = "5" Command = "{Binding UpdateButtonClick}" />
                                                                                                                                                                               

                                                                                                                                                                                                   </ Grid >
                                                                                                                                                                               

                                                                                                                                                                                               </ StackPanel >
                                                                                                                                                                               
                                                                                                                                                                                           </ Border >
                                                                                                                                                                               

                                                                                                                                                                                       </ Grid >
                                                                                                                                                                               

                                                                                                                                                                                   </ Grid >
                                                                                                                                                                               </ Window >*/
