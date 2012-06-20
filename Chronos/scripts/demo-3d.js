jQuery(function(){
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
		defaultParameters : {
			type: "vertical",
			xOffset: 20,
			yOffset: 20,
			hPieces : 10,
			vPieces: 20,
			rotate : 10 ,
			rotateSymmetric: false,
			scaleX:0.5,
			scaleY:-0.5,
			translateX:10,
			translateY:10,
			ease1:"ease",
			ease2:"ease",
			origin:"center center",
			dur1: 1000,
			dur2 :600,
			dur3: 1000,
			pieceDelay : 50,
			xFadeDelay :0,
			prevTransition : 	{
				rotate:-10,
				xOffset:10,
				startFrom:10
			}
		},
		/* For Browsers that support 3D Transforms */
		t3D: {
			type: "vertical3D",
			animateContainer:false,
			containerDelay:0,
			xOffset: 0,
			yOffset: 0,
			vPieces: 30,
			rotate : 0,
			rotateMid : -90,
			rotateZ : 0,
			rotateSymmetric: false,
			scaleX:1,
			scaleY:1,
			scaleZ:1,
			translateX:0,
			translateY:0,
			translateZ:0,
			dur1: 900,
			dur3: 0,
			xFadeDelay: 0 ,
			pieceDelay : 60,
			multiDelay : "linear",
			startFrom:0,
			showFaces:true, //not required. It is true by default
			/* If you want to change faces' background:
			faces : {
				top: "#ff0",
				right: "yellow",
				bottom: "url(images/face-image.png) repeat",
				left: "#000"
			},	
			*/
			ease1:"ease",
			ease2:"ease",
			halfTransition : false,
			prevTransition : {startFrom:"end"}
		},
		/* For Mobile Devices */
		mobile: {
			disableCSS3:true,
			dur1:1200,
			dur2:1200,
			dur3:1200,
			hPieces:4,
			vPieces:4,
			pieceDelay:120,
			rotate:0,
			yOffset:0,
			scaleX:1,
			scaleY:1
		},
		/* For Old and IE Browsers */
		noCSS3:{
			dur1:1200,
			dur2:1200,
			dur3:1200,
			hPieces:4,
			vPieces:4,
			pieceDelay:120,
			xFadeDelay :200
		},
		onStart: function(){ /* Do Something*/ },
		onEnd: function(){ /* Do Something*/ }
	})
})