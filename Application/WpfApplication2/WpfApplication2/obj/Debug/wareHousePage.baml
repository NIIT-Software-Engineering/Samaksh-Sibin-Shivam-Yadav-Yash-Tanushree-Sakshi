   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5      #    WpfApplication2.wareHousePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApplication2     5      -   5          N� Title$  wareHousePage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��75 �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   .+�5      �� -   5        $��addProductButton��5      $	��Add��6.   $��
10,0,20,10q�6<   6P   �� 5      -   5        $��refillProductButton��5      $��Refill��60   $��
10,0,20,10q�6A   6U   5      �� 5   
   -   5        $��updateProductButton��5      $��Bottom=�6,   $��Update��6G   $��
10,0,20,50q�6X   6l   � 5   
   $��1��6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      �� $��	WareHouse��6   $��5q�6)   $��Arial)�64   $��16(�6G   �� 5      -   5        $��wareHouseSearch��5      $��Search��6-   $��Right=�6;   $��Center=�6W   $��18��6r   $	��100��6~   $��0,0,40,0q�6�   6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ wareHouseDataGrid��5      $��1��62   $��
0,10,40,20q�6?      AutoGenerateColumns .  ��6o   �� *LoadDataBinding+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Product Name��5    )      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 5!   )      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5   )   �� 
 �� Path$
 product_name�5"   )     5#      $ Quantity(Box)��5$   )   $ 1* 5%   )    . 	 5#   )   �� $
 product_quantity�5&   )     5'      $ 	Price/Box��5(   )   $ 1* 5)   )    . 	 5'   )   �� $
 product_pricepbox�5*   )     5+      $ Manufacturer��5,   )   $ 1* 5-   )    . 	 5+   )   �� $
 product_manufacturer�5.   )     5/      $ Quantity/Box��50   )   $ 1* 51   )    . 	 5/   )   �� $
 product_qtypbox�52   )   54      55      56      58      