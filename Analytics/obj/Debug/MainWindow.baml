   M S B A M L   `   `   `  ����a  ]Syncfusion.SfChart.WPF, Version=28.2462.5.0, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89eGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPFSyncfusion.UI.Xaml.Charts  5   	   D @Analytics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Analytics.PropertyAnalytics.Property 5   	      Analytics.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   YchartGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPF     5   	   2local clr-namespace:Analytics.Property     5   	     � Title$  	Analytics��5	   	    � WindowState$ Normal=�6    � WindowStyle$
 None=�60    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6]    � DataContext 5
      "  Analytics.Property.ViewModel  5   
   .��5      � -   5         �Name$
 Main��5       � ColumnDefinitions 5   
   �� 5      $	��85* �6   �� 5      $
��299* �6    � RowDefinitions 5   
   �� 5      $	��84* �6   �� 5      $
��451* �6   .+�5   
   �� ���#F4E8D3$��0��6&   $��0��63   $��2��6C   ._�5      �� -   5        	 ��Name$	 Заголовок��5      ���	#FF43CE6D$1��+Аналитический помощник��6B   $��Center=�6`   $��Center=�6}   $��28(�6�   5      �� 5   
   $��0��6   $��1��6!   ._�5      �� .+�5      �� -   5        
 ��Name$
 Product��5      $��10q�6*   ���#F4E8D3 �� CornerRadius$ 15��6K   ._�5      �� $��Аналитика��6   $��20q�60   $��Center=�6<   $��Center=�6Y   ���	#FF43CE6D$��18(�6�   5      �� 5      -   5        $
 Mounth��5      $��10q�6)   ���#F4E8D3$ 15��6J   ._�5      �� $��За месяц��6   $��20q�6/   $��Center=�6;   $��Center=�6X   ���	#FF43CE6D$��18(�6�   5       �� 5!      -   5        $

 Year��5!      $��10q�6'   ���#F4E8D3$ 15��6H   ._�5"      �� $��За год��6   $��20q�6-   $��Center=�69   $��Center=�6V   ���	#FF43CE6D$��18(�6�   5#      �� 5$      -   5        $

 Exit��5$      $��10q�6'   
�������$ 15��6I   ._�5%      �� $)��#Закрыть приложение��6   $��20q�69   $��Center=�6E   $��Center=�6b   
��� E��$��18(�6�   5&      5'      5(      �� 5)   
   $��1��6   $��1��6!   ._�5*      �� ��. $
��Auto=�63   $��Disabled=�6V   .��5+      �� -   5         ��Name$
 Zone��5+      5-      5.      5/      �� 50   
   -   5        $ CloneTender��50      $y�Hidden=�6*    �� Orientation$ Vertical=�6>   $��5q�6U   .+�51      �� -	   5        $	 
TB_product��51      $��Тенденция:��6,   $��Center=�6>   $��Center=�6[   $��15q�6v   ���	#FF43CE6D$��24(�6�   �� 52      -
   5        $	 
CB_product��52      $��15q�6,   ���#F4E8D3���	#FF43CE6D$	��450��6d   $��24(�6p   �� 53      -   5        $	 TB_Shop��53      $:��4Доход на 1 потраченный рубль:��6)   $��Center=�6N   $��Center=�6k   $��15q�6�   ���	#FF43CE6D$��24(�6�   �� 54      -   5        $	 CB_Shop��54      $��15q�6)   ���#F4E8D3���	#FF43CE6D$	��450��6a   $��24(�6m   55      �� 56   
   -   5        $ CloneChartMonth��56      $ Vertical=�6.   $��5q�6E   $y�Hidden=�6P   .+�57      '   !Syncfusion.UI.Xaml.Charts.SfChart  $	��450��6    $
��1100��6-   )   #Syncfusion.UI.Xaml.Charts.ChartBase   Header$ График продаж��6:      Legend 58      +   %Syncfusion.UI.Xaml.Charts.ChartLegend  59         PrimaryAxis 5;      ,   &Syncfusion.UI.Xaml.Charts.CategoryAxis  5<         SecondaryAxis 5>      -   'Syncfusion.UI.Xaml.Charts.NumericalAxis  5?         Series. 5A      ,   &Syncfusion.UI.Xaml.Charts.ColumnSeries  /   )Syncfusion.UI.Xaml.Charts.ChartSeriesBase   Label$ 
Доход��6*      XBindingPath$ Months��6V   ,	   &Syncfusion.UI.Xaml.Charts.XyDataSeries 	  YBindingPath$ ProductA��6l      ItemsSource 68   �� *Month+6l     5B      $ Затраты��6)   $ Months��6W   $ ProductB��6m    69   �� *Month+6m   5C      5D      �� 5E   
   -   5        $ CloneChartYear��5E      $ Vertical=�6-   $��5q�6D   $y�Hidden=�6O   .+�5F        $	��450��6   $
��1100��6)   $ График продаж��66    5G        5H       5J        5K       5M        5N      . 5P        $ 
Доход��6&   $
 Year��6Q   $ ProductA��6e    64   �� *Year+6e     5Q      $ Затраты��6%   $
 Year��6R   $ ProductB��6f    65   �� *Year+6f   5R      5S      5T      5U      