jQuery(function(){
	var myNew3DTransition = {};
	$("#slider").chopSlider({
		/* Slide Element */
		slide : ".slide",
		/* Controlers */
		nextTrigger : "a#slide-next",
		prevTrigger : "a#slide-prev",
		hideTriggers : true,
		sliderPagination : ".slider-pagination",
		/* Captions */
		useCaptions : true,
		everyCaptionIn : ".sl-descr",
		showCaptionIn : ".caption",
		captionTransform : "scale(0) translate(-600px,0px) rotate(45deg)",
		/* Autoplay */
		autoplay : true,
		autoplayDelay : 6000,
		/* Default Parameters */
		t2D : csTransitions['vertical'][1],
		/* Extend the previous transition */
		t3D: $.extend(
			myNew3DTransition , 
			csTransitions['vertical'][1],
			{
				type: "multiFlipV",
				hPieces:1,
				multiDelay:"linear"	
			}
		),
		onStart: function(){ /* Do Something*/ },
		onEnd: function(){ /* Do Something*/ }
	})
})