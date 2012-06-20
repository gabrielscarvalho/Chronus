jQuery(function(){
	$("#slider-1").chopSlider({
		/* Slide Element */
		slide : ".slide1",
		activeSlideClass : "cs-activeSlide",
		/* Controlers */
		nextTrigger : "a.snext-1",
		prevTrigger : "a.sprev-1",
		hideTriggers : true,
		sliderPagination : ".sp-1",
		activePaginationClass : "cs-active-pagination",
		/* For first slider we will use all Multi Transitions */
		t2D : csTransitions['multi']['random']
		
	})
	$("#slider-2").chopSlider({
		/* Slide Element */
		slide : ".slide2",
		activeSlideClass : "cs-activeSlide-2",
		/* Controlers */
		nextTrigger : "a.snext-2",
		prevTrigger : "a.sprev-2",
		hideTriggers : true,
		sliderPagination : ".sp-2",
		activePaginationClass : "cs-active-pagination-2",
		/* For second slider we will use all Multi Transitions */
		t2D : csTransitions['vertical']['random']
		
	})
})

