<template>
    <div>
        <div id="nav-anchor"></div>
        <nav class="navbar navbar-default navbar-fixed-top" role="navigation">
            <div class="container">
                <div class="navbar-header page-scroll">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a href="#page-top" class="navbar-brand page-scroll">
                        <img src="../../../wwwroot/images/HMT-Logo.png" />
                    </a>
                    <a href="#page-top" class="navbar-brand page-scroll">
                        <img src="../../../wwwroot/images/justwords.png" />
                    </a>
                </div>
                <div class="collapse navbar-collapse navbar-ex1-collapse">
                    <ul class="nav navbar-nav navbar-right">
                        <li>
                            <a id="staffLink" class="page-scroll" href="#ourStaff">Our Staff</a>
                        </li>
                        <li>
                            <a id="serviceLink" class="page-scroll" href="#services">Service</a>
                        </li>
                        <li>
                            <a id="appointmentsLink" class="page-scroll" href="#appointments">Book</a>
                        </li>
                        <li>
                            <a id="policyLink" class="page-scroll" href="#policy">Policy</a>
                        </li>
                        <li>
                            <a id="formsLink" class="page-scroll" href="#forms">Forms</a>
                        </li>
                        <li>
                            <a id="resourcesLink" class="page-scroll" href="#resources">Resources</a>
                        </li>
                        <li>
                            <a id="contactLink" class="page-scroll" href="#location">Location</a>
                        </li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Client Portal
                                <span class="caret"></span>
                            </a>
                            <ul class="dropdown-menu">
                                <li>
                                     <a href="https://www.psychselect.com/cgi-bin/therapyappointment/login.cfm?practitioner=21475" target="_blank">Alexandria, VA</a>
                                </li>
                                <li role="separator" class="divider"></li>
                                <li>
                                     <a href="https://www.therapyportal.com/p/healthyminds/" target="_blank">Fredericksburg | Woodbridge, VA</a>
                                </li>
                            </ul>
                        </li>
                        <li>
                           
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <div class="wrapper">
            <div class="main-content">
                <home></home>
                <staff style="background-color: #f5f5f5!important"></staff>
                <services></services>
                <appointments style="background-color: #f5f5f5!important"></appointments>
                <policy></policy>
                <documents style="background-color: #f5f5f5!important"></documents>
                <resources></resources>
                <location style="background-color: #f5f5f5!important"></location>
            </div>
        </div>
        <footer-component></footer-component>
        <a class="scroll-top-wrapper page-scroll hidden-xs" href="#page-top" data-toggle="tooltip" data-placement="bottom" title="Scroll to top">
            <span class="scroll-top-inner">
                <i class="fa fa-2x fa-arrow-circle-up"></i>
            </span>
        </a>
    </div>
</template>

<script>
    import scroller from "../common/scroller";
    import home from "./home.vue";
    import staff from "./staff.vue";
    import appointments from "./appointments.vue";
    import location from "./location.vue";
    import documents from "./documents.vue";
    import policy from "./policy.vue";
    import services from "./services.vue";
    import resources from "./resources.vue";
    import footerComponent from './footer.vue';

    export default {
        name: "app",
        components: {
            home,
            staff,
            appointments,
            location,
            documents,
            policy,
            services,
            resources,
            footerComponent
        }
    };
</script>