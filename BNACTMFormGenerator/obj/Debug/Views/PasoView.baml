   M S B A M L   `   `   `  ����N  JBNACTMFormGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:BNACTMFormGenerator.ViewModelBNACTMFormGenerator.ViewModel  5      (    "BNACTMFormGenerator.Views.PasoView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :vm+clr-namespace:BNACTMFormGenerator.ViewModel     5      $��62��5   3     � 	Resources  5	       �� Source�� 5
   
   $! ..\MainWindowResources.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6$   $��2��61   $	��340��6^   ��6E   �� *	NroPaso+��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFE0E7EA��6#    � Offset$ 0Q�65   � 5      $ 	#FF7DD0F5��6#   $ 1Q�65   5      5      �� 5!   
   $��0��6   $��1��6    $��Servidor de Test:��6-   �� 5"   
   $��1��6   $��1��5#      $
��Left=�5$      $	��200��5%       '  #ToolTipWithErrorMessageOnErrorStyle#��[  5'      ��5&      �� *ServidorTest+ �� Mode$ TwoWay=�	 �� ValidatesOnDataErrors	 . 
 �� NotifyOnValidationError
 . 5'      �� 5)   
   $��0��6   $��2��6    $��Servidor de Producción:��6-   �� 5*   
   $��1��6   $��2��5+      $
��Left=�5,      $	��200��5-      #��[  5/      ��5.      �� *ServidorTest+$ TwoWay=�	 . 
 . 5/      50      51      