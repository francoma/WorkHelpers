   M S B A M L   `   `   `  ����N  JBNACTMFormGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:BNACTMFormGenerator.ViewModelBNACTMFormGenerator.ViewModel  5      E'clr-namespace:BNACTMFormGenerator.ViewsBNACTMFormGenerator.Views  5      5    /BNACTMFormGenerator.Views.PasoCopiaArchivosView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :vm+clr-namespace:BNACTMFormGenerator.ViewModel     5      6vw'clr-namespace:BNACTMFormGenerator.Views     5        � 	Resources  5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $! ..\MainWindowResources.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��24 �6   �� 5      $��21 �6   �� 5      �� 5      $��21 �6   �� 5      �� 5      $��21 �6   �� 5      $	��110 �6   .+�5!   
   �� $��0��6   $��0��6$   $��	PASO N° ��61   $��Right=�6A   $
��Bold"�6]   ��5"      �� 5#       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5$      �  � Color$ 	#FFE0E7EA��6#    � Offset$ 0Q�65   � 5%      $ 	#FF7DD0F5��6#   $ 1Q�65   5&      5(      �� 5)   
   $��1��6   $��0��6"   $
��Left=�6H   $
��Bold"�6c   ��6/   �� *	NroPaso+.��6u   ��5*      �� 5+      $ 0.5,1&�6&   $ 0.5,0&�67   .��5,      � $ 	#FFE0E7EA��6#   $ 0Q�65   � 5-      $ 	#FF7DD0F5��6#   $ 1Q�65   5.      .��5/   "   50      �� 52   
   $��1��6   $��2��6!   $��Origen��65   
����ح�$��Center=�6Z   $
��Bold"�6u   	 �� TextAlignment$	 Center=�6�   $��12(�6�   8   2BNACTMFormGenerator.Views.TransferenciaArchivoView  53   
   $��2��6&   $��2��63   
 � DataContext
 6G   �� *Origen+�� 55   
   $��3��6   $��2��6!   $��Destino��65   
����ح�$��Center=�6[   $
��Bold"�6v   $	 Center=�6�   $��12(�6�     56   
   $��4��6&   $��2��63   
 6G   �� *	Destino+�� 58   
   $��5��6   $��2��6   $��Observaciones��61   $��21��6I   �� 59   
   $��2��6   $��6��5:      $	��100��5;      $	��Top=�5<       �� AcceptsReturn .  '  #ToolTipWithErrorMessageOnErrorStyle#��[  5?      ��5>      �� *Observaciones+ �� Mode$ TwoWay=� �� ValidatesOnDataErrors .  �� NotifyOnValidationError . 5?      5A      5B      